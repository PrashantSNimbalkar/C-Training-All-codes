using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoDictonary
    {
        static void Main(string[] args)
        {


            Dictionary<String, int> dd = new Dictionary<string, int>();

            dd.Add("Ajinkya" , 99); // key value pair string and value is int
            dd.Add("Rupesh", 99);
            dd.Add("Jyoti", 98);

            dd["Ajinkya"] = 100;

            //remove key 
            //dd.Remove("Rupesh");

            Console.WriteLine(dd.Count);

            //dd.Clear();

            Console.WriteLine(dd.ContainsKey("Om"));
            Console.WriteLine(dd.ContainsValue(100));

          //  List<string> keys = dd.Keys.ToList();

            Console.WriteLine(dd["Jyoti"]);


            foreach (KeyValuePair<string , int> kv in dd)
            {

                Console.WriteLine(kv.Key + "=="  + kv.Value);
            }



        }
    }
}
