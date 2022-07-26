using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{


    public delegate int M(int a, int b);
    class DemoDePractice4
    {

        static int mymethod(int a, int b)
        {
            int r = a + b;
            return r;
        }




        static void Main(string[] args)
        {

            M obj = DemoDePractice4.mymethod;

           int r = obj(10,10);

            Console.WriteLine(r);

        }
    }
}
