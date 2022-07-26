using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //19.	WAP to iterate through all elements in a HashSet and print the elements. Observe the order of elements.
    class Class19
    {

        static void Main(string[] args)
        {
            HashSet<int> hh = new HashSet<int>();
           
            hh.Add(6);
            hh.Add(100);
            hh.Add(200);
            hh.Add(300);
            hh.Add(90);
            hh.Add(60);
            
            foreach(int x in hh)
                Console.WriteLine(x);
        }
    }
}
