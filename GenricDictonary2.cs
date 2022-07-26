using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date23062022
{
    class GenricDictonary2
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> obj = new Dictionary<int, string>();

            obj.Add(101,"Aji");   // 101 is key      Aji is value
            obj.Add(102,"Ba");
            obj.Add(103,"CA");
            obj.Add(104, "RA");
            obj.Add(105, "RiA");
                                                 // key always be uniq duplicate key not allow
                                               // key cant be null                     
                                                               // For data retriew you need to know key


            Console.WriteLine(obj.Count); //showing count
            obj[101] = "Puneeeeeeeee";   // replacing value at position 1 - Aji

            obj.Remove(105);  //removing key 105

            foreach (object x in obj)
            {
                Console.WriteLine(x);
            }
             


        }
    }
}
