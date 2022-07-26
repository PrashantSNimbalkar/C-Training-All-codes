using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NullCoalescing
{
    class NullCoalescingDemo2
    {
        static void Main(string[] args)
        {

            string name1 = null;
            string name2 = null;
            string name3 = "Ajinkya";
            string name4 = "Raghav";
            string name5 = null;
            string name6 = null;
            string name7 = null;

            string res = name1 ?? name2 ?? name3 ?? name4 ?? name5 ?? name6 ?? name7;  //return first non-null  first non-null value is Ajinkya

            Console.WriteLine(res);


        
        }
    }
}
