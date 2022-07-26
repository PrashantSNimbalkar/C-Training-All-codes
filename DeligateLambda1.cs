using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate.PracticeDeligate
{

    public delegate void MYDE1(int a, int b);
    class DeligateLambda1
    {

        static void Main(string[] args)
        {
             //outside the class delegate is declare
            // use of lambda      =>

            MYDE1 obj = (a, b) =>
            {
                Console.WriteLine(a*b);
            };

            obj = obj += (a, b) =>
            {
                Console.WriteLine(a+b);
            };

            obj = obj += (a,b) => {
                Console.WriteLine(a-b);
            };

            obj = obj += (a,b)   => {
                Console.WriteLine("I got it");
                Console.WriteLine("Use OF Delegate is Calling Multiple Function using object");
            };

            obj(90,50);
        }
    }
}
