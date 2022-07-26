using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate void Mydele(int a , int b);
    class MulticastDeligate1
    {
         // multicast delegate
        static void add(int a , int b)
        {
            Console.WriteLine($"addition is {a+b}");
        }

        static void mul(int a, int b)
        {
            Console.WriteLine($"Multiplication is {a * b}");
        }


        static void sub(int a, int b)
        {
            Console.WriteLine($"Substraction is {a-b}");
        }


        static void Main(string[] args)
        {

            /*   //1st logic of multicast delegate----
             
            
            
               Mydele obj = MulticastDeligate1.add;

              obj = obj + MulticastDeligate1.sub;
              obj = obj + MulticastDeligate1.mul;



              obj(10,20);

              obj =obj - MulticastDeligate1.sub; //remove sub deligate 

              obj(10, 20);

  */

            /*
                  //2 anonomus Method        Mydele obj = delegate (int a, int b)  // anonomus Method
                        {
                            Console.WriteLine($"Anonomus Method add {a + b}");
                        };

                        obj = obj + delegate (int a, int b)   // anonomus Method
                        {
                            Console.WriteLine($"Anonomus Method Mult {a * b}");
                        };

                        obj = obj + delegate (int a, int b)   // anonomus Method
                        {
                            Console.WriteLine($"Anonomus Method Sub {a - b}");
                        };


                        obj(100,500);
            */



            //lambda =>

            Mydele obj = (a, b) =>
            {

                Console.WriteLine($"{a+b}");
            };

            obj(20,20);



        }
    }
}
