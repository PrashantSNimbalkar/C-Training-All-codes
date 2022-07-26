using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //13.	WAP to get only the Values from a Dictionary.
    class Class13
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dd = new Dictionary<int, string>();

            dd.Add(1, "Ajinkya");
            dd.Add(2, "Shweta");
            dd.Add(3, "Neha");
            dd.Add(4, "Rushika");
            dd.Add(5, "Hritika");

            foreach (KeyValuePair<int, string> x in dd)
            {
                Console.WriteLine(x.Value);
            }
        }
    }
}
