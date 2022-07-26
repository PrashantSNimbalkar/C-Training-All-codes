using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoSortedList
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();

            //showing list Acending order by deafult on keys
            ss.Add("Ram",99);
            ss.Add("Sham",99);
            ss.Add("Ajinkya",99);
            ss.Add("Prasad",99);
            ss.Add("Rehaan" , 99);


            ss.Remove("Rehaan"); //removing rehaan
            ss["Ajinkya"] = 100;
            ss.RemoveAt(1);  //RemoceAt() removing data after sorting  alphabetically removing 0 Ajinkya 1 Prasad
                             //Removing Prasad

            Console.WriteLine(ss.ContainsKey("Prasad")); //returning true or false
            Console.WriteLine(ss.Count); //getting count

            foreach (KeyValuePair<string,int> i in ss)
            {
                Console.WriteLine($"{i.Key}   {i.Value}");
            }


        }
    }
}
