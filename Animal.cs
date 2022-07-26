using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Animal
    {
        private int c = 10;


        public int C  // property writting accessing encapsulate data using property
        {
            get { return c; }
            set { c = value; }
        }


    }

    class run4
    {
        static void Main(string[] args)
        {

            Animal obj = new Animal();

            Console.WriteLine(obj.C);


        }
    }
}
