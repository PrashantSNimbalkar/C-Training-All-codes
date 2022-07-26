using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoLinkedList2
    {

        static void Main(string[] args)
        {
            LinkedList<int> ls = new LinkedList<int>();
            ls.AddFirst(100);
            ls.AddFirst(200);
            ls.AddLast(500);
            ls.AddLast(600);

            LinkedListNode<int> node = ls.Find(100);

            ls.AddAfter(node , 900);


            LinkedListNode<int> node2 = ls.Find(500);

            ls.AddBefore(node2, 666);


            foreach (var item in ls)
            {
                Console.WriteLine(item);
            }
        }
    }
}
