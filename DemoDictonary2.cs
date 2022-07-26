using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoDictonary2
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> dd = new Dictionary<int, string>();

            dd.Add(101,"Ajinkya");
            dd.Add(102, "Rahul");
            dd.Add(103,"Manoj");
          

            Console.WriteLine(dd.Count + " is Count");
            Console.WriteLine(dd[102]);
            Console.WriteLine(dd.ContainsKey(108));
            Console.WriteLine(dd.ContainsValue("Manoj"));

            dd.Add(104,"Sanjay");


            dd[103] = "Sagar";



           



        }
    }
}
