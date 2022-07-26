using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoHashTable
    {
        static void Main(string[] args)
        {
            Hashtable obj = new Hashtable();

            obj.Add(103, "Ajin");
            obj.Add(104, "B");
            obj.Add(105, "PPP");

            ICollection keys = obj.Keys;   //Getting Key Collection   imp


            foreach (int x in keys)
            {
                Console.WriteLine(obj[x]);
            }

        }
    }
}
