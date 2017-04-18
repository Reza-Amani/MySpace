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
        public void update(List<Planet> list)
        {
            double dvx = 0, dvy = 0;
            double fx=0,fy=0,rx,ry,r;
            const double g=6.67408e-11;//m3kg-1s-2
            const double t0 = 100e-3;
            foreach (Planet p in list)
            {
                if (x == p.x && y == p.y)
                    continue;
                rx = p.x - x;
                ry = p.y - y;
                r = System.Math.Sqrt(rx * rx + ry * ry);
                fx += g * mass * p.mass * rx / (r * r * r); //fx=fcosa   f=gm1m2/r^2 rx=rcosa
                fy += g * mass * p.mass * ry / (r * r * r); 
            }
            dvx = fx * t0 / mass;
            dvy = fy * t0 / mass;
            speed_x += dvx;
            speed_y += dvy;
            x += speed_x * t0;
            y += speed_y * t0;
        }
    }
}
