using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeverSpace
{
    class Globals
    {
        public const double G = 6.67408e-11;//m3kg-1s-2
        public const double tick_max = 10e-3;
        public const double tick_min = 1e-4;
        public const double scale_mass = 1e13;
        public const double scale_xy = 1;
        public const double scale_v = 1;
        public const double scale_cubemass_for_radius = 1e-5;

        static Random random_generator = new Random();
        public static bool get_random_bool()
        {
            return (random_generator.Next(0, 2) == 0);
        }
        public static int get_random_int_inc(int min, int max)
        {
            if (min > max)
            {   //don't worry if the order is not correct
                int temp = max;
                max = min;
                min = temp;
            }
            return random_generator.Next(min, max + 1);
        }

    }
}
