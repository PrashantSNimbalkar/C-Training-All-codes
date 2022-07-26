using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Practice22062022
{
    class GenricStack
    {
        static void Main(string[] args)
        {
            //genric fix data or same data
            //if you fix float then genric accept only float

            Stack<float> obj = new Stack<float> () ;

            obj.Push(10.5f);
            obj.Push(10.20f);
            obj.Push(20.1f);
            obj.Push(50.10f);


            obj.Pop(); // remove 50.10


            foreach (object x in obj)
            {
                Console.WriteLine(x);
            }




        }
    }
}
