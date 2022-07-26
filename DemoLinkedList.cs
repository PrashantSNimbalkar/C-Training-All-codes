using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoLinkedList
    {
        
        static void Main(string[] args)
        {
            LinkedList<int> obj = new LinkedList<int>();

            obj.AddLast(100);
            obj.AddLast(200);
            obj.AddFirst(300);
            obj.AddFirst(50);

            LinkedListNode<int> node = obj.Find(100);
            obj.AddAfter(node, 150);
            obj.AddBefore(node, 90);
            obj.Remove(50);

            foreach (int item in obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
