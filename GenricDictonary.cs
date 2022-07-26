using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date23062022
{    //Dictonary

    class GenricDictonary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ob1 = new Dictionary<int, string>();

            ob1.Add(01,"Pune");
            ob1.Add(02, "Mumbai");
            ob1.Add(03, "Nashik");
            ob1.Add(04, "Nagpur");
            ob1.Add(05, "Nagpur"); // key always be uniq duplicate key not allow
                                   // key cant be null                     
                                   // For data retriew you need to know key

            ob1[01] = "Pune Best City"; //Replace

            ob1.Remove(04);

           

            foreach(KeyValuePair<int , string> x in ob1)
            {
                Console.WriteLine(x.Key   +" "   +  x.Value);
            }




        }
    


    }
}
