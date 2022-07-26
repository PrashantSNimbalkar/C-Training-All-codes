using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NullCoalescing
{
    class NullCoalescingDemo
    {
        static void Main(string[] args)
        {

            //   ??  - mean  Null-Coalescing Oprater
            //   it Retrun Left side oprand if Oprand is not-null other wise return right side value 
            // it return first non-null value
            string fruit1 = null;
            string fruit2 = null;
            string fruit3 = "Pineapple";

            string res = fruit1 ?? fruit2 ?? fruit3;
            //   it Retrun Left side oprand if Oprand is not null other wise return right side value 
            // it return first non null value


            Console.WriteLine(res);

        }
    }
}
