using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    //creating delegate

    public delegate void deleg(int a, int b);
    class DemoDePractice1
    {


        static void Mymethod(int a , int b)
        {
            Console.WriteLine(a+b);
        }


        static void Main(string[] args)
        {
            deleg d = DemoDePractice1.Mymethod;

            d(10,10);


        }
    }
}
