﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 3, 5);
            int s3 = Calculator.Sum(2, 4, 5, 6, 3);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
