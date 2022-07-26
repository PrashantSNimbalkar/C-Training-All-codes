using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Pratice_revision
{
    class Class5
    {
        static void Main(string[] args)
        {
            //loop

            int c = 0;
            int i = 21;

            while (i <= 30)
            {
                Console.WriteLine(i);
                i++;
                c++;
            }
            Console.WriteLine(c);


            Console.WriteLine(  "//////////////////////////");

            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);


            Console.WriteLine("/////////////////////////////////");

            int j1 = 0;
            do
            {
                Console.WriteLine(j1);
                j1++;
            }
            while (j1 < 5);

            Console.WriteLine("/////////////////////////////////");


            int p = 0;
            do
            {
                Console.WriteLine(p);
                p++;
            } while (p<10);


        }
    }
}
