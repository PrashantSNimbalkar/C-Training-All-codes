using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //8.	WAP to print list in reverse order .
    class Class8
    {

        static void Main(string[] args)
        {
            List<int> ls = new List<int>();

            ls.Add(1);
            ls.Add(2);
            ls.Add(3);
            ls.Add(4);
            ls.Add(5);
            Console.WriteLine("List Before Reverse : ");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }



            ls.Reverse(); //using reverse() method

            Console.WriteLine("\nList After Reverse : ");
            foreach (int x in ls)
            {
                Console.WriteLine(x);
            }





        }

    }
}
