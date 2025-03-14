﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos
{
    class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circuferencia(double r)
        {
            return 2.0 * Pi * Math.Pow(r, 3); //  Math.Pow(r,3) == r*r*r
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
