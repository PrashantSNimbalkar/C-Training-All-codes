using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class FindAll
    {

        static bool isodd(int n)
        {

            Console.WriteLine("  All List : " + n);

            return n % 2 == 1;

            
        }

        static void Main(string[] args)
        {

            List<int> lst = new List<int>() { 10,20,30,40,50,60,70,80,90,100,102,105,104,108,104,103};

                    //    lst.FindAll(isodd);   

            List<int> lst2 = lst.FindAll(isodd);  // storing value of       lst.FindAll(isodd);   in    lst2


            foreach (int i in lst2)
            {
                Console.WriteLine($"odd number from list is {i}");
            }

        }



    }
}
