using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //16.	WAP to create a Stack to store some objects and iterate over it.Also show use od push,pop,peek.
    class Class16
    {
        static void Main(string[] args)
        {

            Stack<int> ss = new Stack<int>();
            //LIFO

            ss.Push(100);
            ss.Push(200);
            ss.Push(300);
            ss.Push(400);
            ss.Push(500);
            ss.Pop();  // delete 500 coz LIFO

            ss.Push(600); // adding 600
            ss.Push(700); // adding 700
            ss.Pop(); // removing 700

            Console.WriteLine("Peek is Showing Which Element is On Top of Stack "  + ss.Peek());
           


            foreach (int item in ss)
            {
                Console.WriteLine(item);
            }


        }
    }
}
