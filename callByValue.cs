using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class callByValue
    {
        static void method(int insidevalue)
        {

            insidevalue = insidevalue + 10;  // value is 20+10 = 30  but it go back to main method value is again 20
                                             //this is call by value value is not change in main method it still 20

            Console.WriteLine("Inside method " + insidevalue);

        }



        static void Main(string[] args)
        {

            int x = 20;

            method(x);


            Console.WriteLine("Main Method" + x);   // ans is 20 just bcoz it is call by value 
        }
    }
}
