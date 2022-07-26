using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //15.	WAP to create a Queue to add 5 objects and also remove first two and iterate over it. 


    class Class15
    {
        static void Main(string[] args)

        {

            Queue<int> q = new Queue<int>();

            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);
            q.Enqueue(500);

            q.Dequeue();
            q.Dequeue();


            foreach(int i in q)
                Console.WriteLine(i);

        }
    }
}
