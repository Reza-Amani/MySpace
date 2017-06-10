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
        double closest_planet;
        public bool fix;


        public Planet(double _x, double _y, double _mass, int _radius, double _speed_x, double _speed_y, bool _fix)
        {
            x = _x; y = _y; mass = _mass; radius = _radius; speed_x = _speed_x; speed_y = _speed_y; fix = _fix;
        }
        public void split(out Planet _new_planet, int _new_mass_pc, int _new_intenergy_pc, int _new_relative_angle)
        {
            _new_planet = new Planet(x+20,y+30,mass*_new_mass_pc/100,10,10,10,false);
        }
        public void update(List<Planet> list, double _tick, out bool _time_critical)
        {
            if (!fix)
            {
                double dvx = 0, dvy = 0;
                double fx = 0, fy = 0, rx, ry, r;
                double nearest_r = Double.MaxValue;
                foreach (Planet p in list)
                {
                    if (x == p.x && y == p.y)
                        continue;
                    rx = p.x - x;
                    ry = p.y - y;
                    r = System.Math.Sqrt(rx * rx + ry * ry);
                    if (nearest_r > r)
                        nearest_r = r;
                    fx += Globals.G * mass * p.mass * rx / (r * r * r); //fx=fcosa   f=gm1m2/r^2 rx=rcosa
                    fy += Globals.G * mass * p.mass * ry / (r * r * r);
                }
                dvx = fx * _tick / mass;
                dvy = fy * _tick / mass;
                speed_x += dvx;
                speed_y += dvy;
                x += speed_x * _tick;
                y += speed_y * _tick;
                if (nearest_r < 0.9 * closest_planet)
                    _time_critical = true;
                else
                    _time_critical = false;
                closest_planet = nearest_r;

            }
            else
                _time_critical = false;
        }
    }
}
