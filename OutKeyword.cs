using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class OutKeyword
    {

         // call by out
        static void method(out int insidevalue)
        {
            insidevalue = 0;
            insidevalue = insidevalue + 10;
            Console.WriteLine("Inside method " + insidevalue); //op is 10
        }



        static void Main(string[] args)
        {

            int x = 20;

            method(out x);


            Console.WriteLine("Main Method " + x);  //op is 10
        }

    }
}
