﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            byte b = 255;
            short c = 30000;
            long d = 1000000000000000000;
            ulong e = 10000000000000000000;
            float f = 3.1421513523463245634573475f;
            double g = 3.1421513523463245634573475;
            decimal h = 3.1421513523463245634573475m;

            Console.WriteLine("sbyte a: " + a);
            Console.WriteLine("byte b: " + b);
            Console.WriteLine("short c: " + c);
            Console.WriteLine("long d: " + d);
            Console.WriteLine("long e: " + e);
            Console.WriteLine("float f: " + f);
            Console.WriteLine("double g: " + g);
            Console.WriteLine("decimal j: " + h);
        }
    }
}
