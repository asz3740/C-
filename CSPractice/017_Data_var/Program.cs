﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Data_var
{
    class Program
    {
        // 선언과 동시에 초기화,지역 변수 
        // var noInitialVar = 100;

        static void Main(string[] args)
        {
            var a = 100;
            var b = 3.1415926535897932384626433832f;
            var c = 3.1415926535897932384626433832m;
            var d = 'H';
            var e = 'i';
            var f = "World!!";
            var g = false;

            Console.WriteLine("type: {0}, a: {1}", a.GetType(), a);
            Console.WriteLine("type: {0}, b: {1}", b.GetType(), b);
            Console.WriteLine("type: {0}, c: {1}", c.GetType(), c);
            Console.WriteLine("type: {0}, g: {1}", g.GetType(), g);

            Console.WriteLine("{0}{1} {2}", d, e, f);

            var num = 0;
            num = 100;

            Console.WriteLine("num: " + num);
        }
    }
}
