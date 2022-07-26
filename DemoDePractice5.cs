using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate double deleg1(double a , double b);
    class DemoDePractice5
    {

        static double M(double a , double b)
        {
            double x = a * b;
            return x;
        }


        static void Main(string[] args)
        {
            deleg1 obj = DemoDePractice5.M;
            double r =  obj(10,10);
            Console.WriteLine(r);
        }
    }
}
