using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate void dele1(int r);
    class DemoDePractice2
    {
        static void mymeto(int r)
        {
            Console.WriteLine($"Value of r is {r}");
        }

        static void Main(string[] args)
        {

            dele1 obj = DemoDePractice2.mymeto;

            obj(10);


        }
    }
}
