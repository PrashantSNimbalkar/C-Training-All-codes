using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ACollections.Date23062022
{

     //practice 2
    class GenricListConcatination2
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>() ;

            L1.Add(01);
            L1.Add(02);
            L1.Add(03);


            List<int> L2 = new List<int>() ;

            L2.Add(11);
            L2.Add(22);
            L2.Add(33);

            L1.AddRange(L2);  // Concinatation of two list

            foreach (object x in L1)
            {
                Console.Write(" " + x);  // Concinated
            }




        }
    }
}
