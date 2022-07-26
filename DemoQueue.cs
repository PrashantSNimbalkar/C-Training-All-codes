using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<String> qq = new Queue<string>();
            //FIFO

            qq.Enqueue("Ajinkya");
            qq.Enqueue("Computer");
            qq.Enqueue("Science");
            qq.Dequeue(); //delete Ajinkya just coz of FIFO

        

            foreach (String item in qq)
            {
                Console.WriteLine(item);
            }
        }
    }
}
