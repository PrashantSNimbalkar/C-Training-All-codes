using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date23062022
{

         // concating two list 
    class GenricListConcatination1
    {
        static void Main(string[] args)
        {


        List<char> L1 = new List<char>() { 'A' ,'j', 'i' ,'n'};

        List<char> L2 = new List<char>() { 'k' , 'y' , 'a'};


            L1.AddRange(L2);   // this method used to concanitation 

           foreach(object x in L1)
            {
                Console.Write(x);
            }

            

        }

    }
}
