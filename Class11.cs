using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //11.	WAP to add elements to a Dictionary and print content of it.
    //Use int as Key and String as Value.
    //In second Dictionary add elements of String type as Key and Int as Value.
    class Class11
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dd = new Dictionary<int, string>();

            dd.Add(1,"Ajinkya");
            dd.Add(2,"Shweta");
            dd.Add(3,"Neha");
            dd.Add(4,"Rushika");
            dd.Add(5,"Hritika");

            foreach (KeyValuePair<int ,string> x in dd)
            {
                Console.WriteLine(x.Key  + " " +  x.Value);
            }

            Dictionary< string , int> dd2 = new Dictionary<string , int>();


            dd2.Add("Ram" ,1);
            dd2.Add("Krishna" , 2);
            dd2.Add("Hari", 3);

            foreach (KeyValuePair<string, int> x in dd2)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }



        }
    }
}
