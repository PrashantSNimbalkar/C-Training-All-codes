using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //9.	WAP to sort the elements of List that contains String objects. Print List.
    class Class9
    {


        static void Main(string[] args)
        {
            List<string> ll = new List<string>();
            ll.Add("Prasad");
            ll.Add("Ajinkya");
            ll.Add("Shweta");
            ll.Add("Neha");
            ll.Add("Deepti");

            ll.Sort();

            foreach (string x in ll)
            {
                Console.WriteLine(x);
            }

        }



    }
}
