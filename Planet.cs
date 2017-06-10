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
        public double ienergy;

        public Planet(double _x, double _y, double _mass, int _radius, double _speed_x, double _speed_y, double _ienergy, bool _fix)
        {
            x = _x; y = _y; mass = _mass; radius = _radius; speed_x = _speed_x; speed_y = _speed_y; ienergy = _ienergy; fix = _fix;
        }
        public void split(out Planet _new_planet, double _new_mass_ratio, double _added_speed_x, double _added_speed_y)
        {
            double old_momentum_x = mass * speed_x;
            double old_momentum_y = mass * speed_y;
            double baby_mass = mass * (1 - _new_mass_ratio);
            mass *= _new_mass_ratio;
            speed_x += _added_speed_x;
            speed_y += _added_speed_y;
            
                //baby momentum = old_momentum - new momentum; baby speed = baby momentum/baby mass
            double baby_momentum_x = old_momentum_x - mass * speed_x;
            double baby_momentum_y = old_momentum_y - mass * speed_y;
            double baby_speed_x = baby_momentum_x / baby_mass;
            double baby_speed_y = baby_momentum_y / baby_mass;
            double baby_x = (_added_speed_x>0)?x-4*radius:x+4*radius;//TODO: review 4*, also, update the energies due to changed citetic energy
            double baby_y = (_added_speed_y > 0) ? y - 4 * radius : y + 4 * radius;//TODO: review 4*, also, update the energies due to changed citetic energy
            _new_planet = new Planet(baby_x, baby_y, baby_mass, 10, baby_speed_x, baby_speed_y, 0, false);
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
