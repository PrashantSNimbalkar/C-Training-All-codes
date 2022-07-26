using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class RefKeyword
    {


        /* 
         *   //call by value
         *   
         *   
         * static void method(int insidevalue)
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

         }*/




        //call by reference
        static void method(ref int insidevalue)
        {

            insidevalue = insidevalue + 10;  
            Console.WriteLine("Inside method " + insidevalue);  // call by ref so it work on ref
                                                               // addition of 20 + 10  =30 you get 30 
                                                               //when it go back to main method still you get 30 bcoz of call by ref

        }



        static void Main(string[] args)
        {

            int x = 20;

            method(ref x);


            Console.WriteLine("Main Method" + x);  // main method still you get 30 bcoz of call by ref
                                                    // it work on ref not on value  so you get 30

        }

    }
}
