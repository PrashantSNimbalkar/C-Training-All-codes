using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1.MultiThreading
{
    class MultiThreading1
    {


        static void Mym()
        {
            for(int i = 1; i<= 20; i++)
            {
                Console.WriteLine($" Mym  Loop {Thread.CurrentThread.Name}" );
            }
        }




        static void Main(string[] args)
        {


            Console.WriteLine("Ajinkya");
            Console.WriteLine("We r in MultiThreating ......");


            Thread t1 = new Thread(Mym);
            t1.Start();

            t1.Name = "t1";

            /*Console.WriteLine("Enter Number");
            int x = int.Parse(Console.ReadLine());

*/
            for (int j = 1; j<=10; j++)
            {
                Console.WriteLine("J Loop" +Thread.CurrentThread.Name);
            }


        }
    }
}
