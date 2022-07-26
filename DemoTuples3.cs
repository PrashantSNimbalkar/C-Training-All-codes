using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tuples
{
    class DemoTuples3
    {

        public static (int a, int b,int c, int d,int e, int f,int g,int h, int i,int j) method()
        {
            return (10,20,30,40,50,60,70,80,90,100);
        }

        static void Main(string[] args)
        {

           var x =  method();

            Console.WriteLine($"{x.a} {x.b} {x.c} {x.c} {x.e} {x.f} {x.g} {x.h} {x.i} {x.j}");
        }
    }
}
