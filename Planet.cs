using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeverSpace
{
    class Planet
    {
        public int radius;
        public double x, y, speed_x, speed_y, mass;


        public Planet(int _x, int _y, double _mass, int _radius, double _speed_x, double _speed_y)
        {
            x = _x; y = _y; mass = _mass; radius = _radius; speed_x = _speed_x; speed_y = _speed_y;
        }
        public void update()
        {
            x += speed_x;
            y += speed_y;
        }
    }
}
