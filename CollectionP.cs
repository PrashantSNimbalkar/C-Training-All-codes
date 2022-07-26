using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class CollectionP
    {
      
        static void Main(string[] args)
        {

            List<string> lst2 = new List<string>() { "Medha" , "Deepa" , "Kalyani"};

            

          
            

            List<string> lst = new List<string>(20);

            lst.Add("A");
            lst.Add("B");
            lst.Add("A");
            lst.Add("D");
            lst.Add("A");
            lst.Add("E");
            lst.Add("H");

            // lst.Clear();

            /* int a =  lst.IndexOf("A");
               Console.WriteLine(a);*/

            /* int a = lst.LastIndexOf("A");
             Console.WriteLine("Last Index" + a);*/

          //  lst.AddRange(lst2);

            lst.InsertRange(2,lst2);

            // lst.ToArray();

            //lst.Insert();
            //lst.Remove();
            //lst.Count();
            //lst.RemoveAt();
            //lst.Clear();
            //lst.Contain("A"); //return true or -1 

            //lst.Sort();
            //lst.Reverse();
           

            foreach (string x in lst)
            {
                Console.WriteLine(x);
            }

        }
       


    }
}
