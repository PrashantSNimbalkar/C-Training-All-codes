using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static int x = 10;

        static void Main(string[] args)
        {

            //Arithmatic Progression
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            int d = a3 - a2;

            for (int i = 4; i <= n; i++)
            {
                a3 = a3 + d;

            }
            Console.WriteLine(a3);

        }
    }
}
