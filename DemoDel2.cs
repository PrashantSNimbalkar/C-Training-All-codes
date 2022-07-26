using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate int mydele1(int n);
    class DemoDel2
    {

        static int fac1(int n)
        {
            int fact=1;
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
           }
            return fact;
        }

        static void Main(string[] args)
        {

            mydele1 d = DemoDel2.fac1;
           int r =  d(10);

            Console.WriteLine(r);
        }
    }
}
