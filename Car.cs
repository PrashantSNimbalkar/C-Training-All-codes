using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Car
    {
        public string name;

        public Car()  // creating constructor class name same and no return type
        {
            name = "Bangar";
            Console.WriteLine(name);

        }
    }

    class run
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            
        }
    }


}
