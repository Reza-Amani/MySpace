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
                    Planet new_planet = new Planet(form.x, form.y, form.mass, form.radius, form.speed_x, form.speed_y, form.fix);
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
                Thread.Sleep(100);
                update_1day(null);
            }
        }

        private void update_1day(object state)
        {
            foreach (Planet planet in planets)
            {
                planet.update(planets);
            }
            graphics.reset_view();
            foreach (Planet planet in planets)
            {
                graphics.draw_circle((int)planet.x, (int)planet.y, planet.radius, Color.AliceBlue);
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

    }
}
