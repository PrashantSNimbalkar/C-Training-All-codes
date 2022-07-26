using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Pratice_revision
{
    class Class4
    {
        static void Main(string[] args)
        {
            //switch

            Console.WriteLine("Enter Day Number between 1 to 7");

            int x = int.Parse(Console.ReadLine());


            switch (x)
            {
                case 1:
                    Console.WriteLine("Sun");
                    break;
                case 2:
                    Console.WriteLine("Mon");
                    break;
                case 3:
                    Console.WriteLine("Tue");
                    break;
                case 4:
                    Console.WriteLine("Wend");
                    break;
                case 5:
                    Console.WriteLine("Thur");
                    break;
                case 6:
                    Console.WriteLine("Fri");
                    break;
                case 7:
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine("Enter only bet 1 to 7");
                    
                    break;


            }

            



        }
    }
}
