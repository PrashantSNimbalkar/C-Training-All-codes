using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate.PracticeDeligate
{

    //creating delegate

    public delegate void MYDE(int a ,int b);
    class MulticastDelegate1
    {

        static void add(int a, int b)
        {
            Console.WriteLine($"addition is {a + b}");
        }

        static void mul(int a, int b)
        {
            Console.WriteLine($"Multiplication is {a * b}");
        }


        static void sub(int a, int b)
        {
            Console.WriteLine($"Substraction is {a - b}");
        }
        static void Main(string[] args)
        {
            /*
                        //multicast 1st way
                        MYDE obj = MulticastDelegate1.add;

                        obj = obj + MulticastDelegate1.sub;
                        obj = obj + MulticastDelegate1.mul;
           
            
            
            obj =obj - MulticastDeligate1.sub; //remove sub deligate 

                obj(10,10);
            */





            /*
                        //multicast 2nd Way   Annonomus Method


                        MYDE obj = delegate (int a, int b)
                        {
                            Console.WriteLine($"Addition is {a+b}");
                        };


                        obj = obj + delegate (int a, int b) {

                            Console.WriteLine($"Multiplication is {a*b}");
                        };


                        obj = obj + delegate (int a, int b)
                        {
                            Console.WriteLine($"Substraction is {a - b}");
                        };



                        obj(40,30);

            */


            // 3rd way lambda =>


             // note for the lambda no need to write a statics method just write deligate method

            MYDE obj = (a, b) =>
            {
                Console.WriteLine($"Addition is {a+b}");
            };

          obj=  obj +=  (a,b) =>
                {
                    Console.WriteLine($"Multiplication is {a*b }");
            };


            obj = obj += (a, b) => {
                Console.WriteLine($"Sub is {a-b}");
            };


            obj(10,10);











        }

    }
}
         



