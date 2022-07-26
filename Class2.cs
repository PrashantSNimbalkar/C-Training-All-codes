using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Params
{
    class Class2
    {
        static int method(params int[] AA)
        {
            int x = 0;
            foreach (int xx in AA)
            {
                Console.WriteLine(xx);
          
            }
            return x;
           
        }
        static void Main(string[] args)
        {
            int re = method(10,500,30);

        }
    }
}
