using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Car2
    {
        public Car2(int x) // constructor
        {
            Console.WriteLine(x + "Bangar");
        }
    
        public Car2()// constructor
        {
            Console.WriteLine("Ajinkya");
        }

        public Car2(int a, int b)// constructor
        {
            Console.WriteLine(a + b);
        }

    }
    class run2
    {
        static void Main(string[] args)
        {
            Car2 obj = new Car2();
            Car2 obj2 = new Car2(10,10);
            Car2 obj3 = new Car2(10);
        }
    }
}