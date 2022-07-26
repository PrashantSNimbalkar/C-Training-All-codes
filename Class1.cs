using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Params
{
    class Class1
    {



        static void method(params int[]  AA)
        {

            foreach (int xx in AA)
            {
                Console.WriteLine(xx);
            }

        }


        static void Main(string[] args)
        {

            method(10,20,30);


        }

    }
}
