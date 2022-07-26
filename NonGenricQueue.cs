using System;
using System.Collections;
using System.Text;

namespace ConsoleApp1.ACollections.Practice22062022
{
    class NonGenricQueue
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue();

            obj.Enqueue("ABC");
            obj.Enqueue(500);
            obj.Enqueue(300);
            obj.Enqueue("ThinkQuetient");
            obj.Enqueue("10");
            obj.Enqueue(500);
            obj.Enqueue(300);


            obj.Dequeue(); //removing ABC coz its Queue FIFO

            foreach(object x in obj)
            {
                Console.WriteLine(x);
            }


        }
    }
}
