using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Carr
    {

        public int x;

        public Carr() // constructor always same name of class and no return type like void int strng....
        {
            x = 10;
            Console.WriteLine(x);
        }


        public Carr(string c)
        {
            Console.WriteLine(c);
        }

    }

    class run3
    {
        static void Main(string[] args)
        {
            Carr obj = new Carr();
            Carr obj2 = new Carr("Ajinkya");

        }
    }
}
