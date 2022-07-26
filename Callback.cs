using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DelegateLambda
{
    class Callback
    {
        public static void Display()
        {
            Console.WriteLine("Good Morning");
        }
        public static void Square(int a , Action d1)
        {
            Console.WriteLine($"Square is {a*a}");
           d1();
        }

            static void Main(string[] args)
        {

            Square(9, Display);

        }

    }
}
