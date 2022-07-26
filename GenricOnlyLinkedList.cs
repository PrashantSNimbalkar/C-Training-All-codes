using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date24062022
{
    class GenricOnlyLinkedList
    {
        static void Main(string[] args)
        {

            LinkedList<int> LL = new LinkedList<int>();
            LL.AddLast(152);
            LL.AddFirst(100);
            LL.AddFirst(2100);
            LL.AddFirst(200);
            LL.AddLast(10);
            LL.Remove(152);


            LinkedListNode<int> addr = LL.Find(2100);
            LL.AddAfter(addr , 2100);

            foreach (int x in LL)
            {
                Console.WriteLine(x);
            }

        }
    }
}
