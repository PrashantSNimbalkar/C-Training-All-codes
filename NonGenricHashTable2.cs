using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.ACollections.Date23062022
{
    class NonGenricHashTable2
    {

        static void Main(string[] args)
        {
            Hashtable obj = new Hashtable();

            obj.Add(103,"Ajin");
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
