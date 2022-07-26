using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Practice22062022
{
    class GenricQueue
    {
        static void Main(string[] args)
        {
            Queue<int> obj = new Queue<int>();   //genric queue fix int .........
                                                 // FIFO first in first Out
                                                 // 

            obj.Enqueue(100);//Enqueue use for Adding element
            obj.Enqueue(500);
            obj.Enqueue(1005);
            obj.Enqueue(5200); 
            obj.Enqueue(1020);
            obj.Enqueue(5020);
            obj.Enqueue(800);

            obj.Dequeue(); // remove 100 Beacause its FIFO
           

            foreach(object x in obj)
            {
                Console.WriteLine(x);
            }

        }
    }
}
