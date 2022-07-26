using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Animal3
    {
        int a = 10;

        public int A {
            get { return a; }
            set { a = value; }
        }
    }
    class run6
    {
        static void Main(string[] args)
        {
            Animal3 obj = new Animal3();
            Console.WriteLine(obj.A);
           
        }
    }
}
