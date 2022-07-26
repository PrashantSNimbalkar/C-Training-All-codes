using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.ACollections.Date23062022
{
    class NonGenricArrayListConcatination1
    {
        static void Main(string[] args)
        {

            ArrayList L1 = new ArrayList() { 1 , "Aji" , 35 , 90 , 50};

            ArrayList L2 = new ArrayList() {2 , "Ba" , 62 , 68 , 8 , 9 };


            foreach (object x in L1)        // list Item in L1
            {
                Console.Write(" " + x);
            }
            Console.WriteLine();
            foreach (object x in L2)            // list Item in L2
            {
                Console.Write(" " + x);
            }

            Console.WriteLine();

            L1.AddRange(L2);   // Concate two List 

            foreach(object x in L1)   // printing Concatination
            {
                Console.Write("   " +  x);
            }



        }
    }
}
