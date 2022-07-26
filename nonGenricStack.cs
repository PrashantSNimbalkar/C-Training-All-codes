using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ConsoleApp1.ACollections.Practice22062022
{
    class nonGenricStack
    {
        static void Main(string[] args)
        {
            //LIFO last in first out

            Stack s = new Stack();

            s.Push(100);
            s.Push(1000);
            s.Push(20);
            s.Push(500);  //push similar to add
            
            s.Pop();  // pop remove element 500
            s.Pop();  // pop remove 20

            foreach(object r in s)
            {
                Console.WriteLine(r);
            }
        }
    }
}
