using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NeverSpace
{
    public partial class MainForm : Form
    {
        graphic graphics;
        List<Planet> planets = new List<Planet>();

        bool TimeToGo = false;
        int zoom_factor = 1;
        double tick = Globals.tick_max;
        int clickx1, clickx2, clicky1, clicky2;
        public MainForm()
        {
            InitializeComponent();
            graphics = new graphic(pictureBoxSpace);
        }

        private void button_simple_start_Click(object sender, EventArgs e)
        {
            graphics.reset_view();
            graphics.draw_circle(50, 50, 10,Color.AliceBlue);
            graphics.apply_view();

        }

        private void buttonAddPlanet_Click(object sender, EventArgs e)
        {
            NewPlanetForm form = new NewPlanetForm();
            switch (form.ShowDialog(this))
            {
                case DialogResult.OK:
                    Planet new_planet = new Planet(form.x, form.y, form.mass, form.radius, form.speed_x, form.speed_y, form.ienergy, form.fix);
                    planets.Add(new_planet);
                    labelOut.Text = form.x.ToString();
                    break;
                case DialogResult.Cancel:
                    break;
            }
            form.Dispose();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            TimeToGo = true;
            Thread thread = new Thread(thread_go);
            thread.Start();
        }

        private void button1Tick_Click(object sender, EventArgs e)
        {
            TimeToGo = false;
            update_1day(null);
        }
        private void thread_go()
        {
            while (TimeToGo)
            {
                Thread.Sleep((int)(1000*tick));
                update_1day(null);
            }
        }

        private void adjust_time_base(bool _to_decrease)
        {
            if (_to_decrease)
            {
                if (tick >= 2 * Globals.tick_min)
                    tick /= 2;
            }
            else
            {
                if (tick <= 0.5 * Globals.tick_max)
                    tick *= 2;
            }
        }
        private void update_1day(object state)
        {
            bool time_critical = false;
            bool t0_to_update = false;
            foreach (Planet planet in planets)
            {
                planet.update(planets, tick, out time_critical);
                if (time_critical)
                    t0_to_update = true;
            }
            adjust_time_base(t0_to_update);
       //     labelOut.Text = tick.ToString();

            graphics.reset_view();
            foreach (Planet planet in planets)
            {
                graphics.draw_circle(graphics.get_box_width()/2 + (int)planet.x / zoom_factor, graphics.get_box_height()/2 + (int)planet.y / zoom_factor, planet.radius/zoom_factor, Color.AliceBlue);
            }
            graphics.apply_view();
            //            world.update_1day();
//            if (graphic_onoff)
//                world.update_graphics();
//            SetText(world.get_world_info(), world.get_point_info(wform.click_x, wform.click_y), world.get_cell_info());
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            TimeToGo = false;
        }

        private void buttonPlanetOnSpace_Click(object sender, EventArgs e)
        {
            clickx1 = 0; clickx2 = 0; clicky1=0; clicky2=0;
        }

        private void pictureBoxSpace_Click(object sender, EventArgs e)
        {
           var mouseEventArgs = e as MouseEventArgs;
           if (mouseEventArgs != null)
           {
               if (clickx1 == 0 && clicky1 == 0)
               {
                   clickx1 = zoom_factor*(mouseEventArgs.X-graphics.get_box_width()/2);
                   clicky1 = zoom_factor*( mouseEventArgs.Y-graphics.get_box_height()/2);
               }
               else if (clickx2 == 0 && clicky2 == 0)
               {
                   clickx2 = zoom_factor * (mouseEventArgs.X - graphics.get_box_width() / 2);
                   clicky2 = zoom_factor * (mouseEventArgs.Y - graphics.get_box_height() / 2);

                   NewPlanetForm form = new NewPlanetForm();
                   form.mass = 5000;
                   form.radius = 5;
                   form.x=clickx1;
                   form.y = clicky1;
                   form.speed_x = clickx2 - clickx1;
                   form.speed_y = clicky2 - clicky1;
                   switch (form.ShowDialog(this))
                   {
                       case DialogResult.OK:
                           Planet new_planet = new Planet(form.x, form.y, form.mass, form.radius, form.speed_x, form.speed_y, form.ienergy, form.fix);
                           planets.Add(new_planet);
                           labelOut.Text = form.x.ToString();
                           update_1day(null);
                           break;
                       case DialogResult.Cancel:
                           break;
                   }
                   form.Dispose();

               }
           }
        }

        private void button_zoomout_Click(object sender, EventArgs e)
        {
            zoom_factor *= 2;
            update_1day(null);

        }

        private void button_zoomin_Click(object sender, EventArgs e)
        {
            if (zoom_factor >= 2)
                zoom_factor /= 2;
            update_1day(null);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonTemp_Click(object sender, EventArgs e)
        {
            Planet new_planet;
            planets[0].split(out new_planet, 50, 50, 0);
            planets.Add(new_planet);
        }

    }
}
