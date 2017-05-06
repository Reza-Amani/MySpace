using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeverSpace
{
    class graphic
    {
        Graphics g;
        Bitmap btm;
        PictureBox box;

        SolidBrush brush = new SolidBrush(Color.AliceBlue);
        public graphic(PictureBox picture_box)
        {
            box = picture_box;
            btm = new Bitmap(box.Width, box.Height);
            g = Graphics.FromImage(btm);  //graphics for a boundary
            box.Image = btm;
            Color color = Color.DarkRed;
        }
        public int get_box_width()
        {
            return box.Width;
        }
        public int get_box_height()
        {
            return box.Height;
        }
        public void reset_view()
        {   //resetting the view
            g.FillRectangle(Brushes.Black, 0, 0, box.Width, box.Height);
        }
        public void draw_circle(int display_x, int display_y, int _radius, Color _color)
        {   //draw a circle given center and radius, without updating the view
            if (_radius < 2)
                _radius = 2;
            if (display_x > (0-_radius) && display_x < (box.Width+_radius) && display_y > (0-_radius) && display_y < (box.Height+_radius))
            {
                brush.Color = _color;
                g.FillEllipse(brush, display_x - _radius, display_y - _radius, 2 * _radius, 2 * _radius);
            }
        }
        public void apply_view()
        {   //finalising the draw and showing the result
            box.Image = btm;
        }
/*        public void draw_bmp(Bitmap _bmp, int _x, int _y)
        {
            g.DrawImageUnscaled(_bmp, _x, _y);
        }
*/
    }
}
