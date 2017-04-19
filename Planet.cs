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
        public bool fix;


        public Planet(double _x, double _y, double _mass, int _radius, double _speed_x, double _speed_y, bool _fix)
        {
            x = _x; y = _y; mass = _mass; radius = _radius; speed_x = _speed_x; speed_y = _speed_y; fix = _fix;
        }
        public void update(List<Planet> list)
        {
            if (!fix)
            {
                double dvx = 0, dvy = 0;
                double fx = 0, fy = 0, rx, ry, r;
                foreach (Planet p in list)
                {
                    if (x == p.x && y == p.y)
                        continue;
                    rx = p.x - x;
                    ry = p.y - y;
                    r = System.Math.Sqrt(rx * rx + ry * ry);
                    fx += Globals.G * mass * p.mass * rx / (r * r * r); //fx=fcosa   f=gm1m2/r^2 rx=rcosa
                    fy += Globals.G * mass * p.mass * ry / (r * r * r);
                }
                dvx = fx * Globals.t0 / mass;
                dvy = fy * Globals.t0 / mass;
                speed_x += dvx;
                speed_y += dvy;
                x += speed_x * Globals.t0;
                y += speed_y * Globals.t0;
            }
        }
    }
}
