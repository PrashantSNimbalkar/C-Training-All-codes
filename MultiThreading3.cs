using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1.MultiThreading
{
    class MultiThreading3
    {
        static void mm()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"This Is Thread  ----{Thread.CurrentThread.Name}");
            }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine($"Ajinkya..............   {Thread.CurrentThread.Name} ");

            Thread t1 = new Thread(mm);
         
            // t1.Abort(); // Abort()  destroy thread Automatically before it destroy itself

            t1.Start();
            t1.Name = "2nd Thread";


             t1.Join();   // join() is  whenever t1 thread not compliting their logic main thread not moving ahead
            
            for (int i = 1; i<= 20; i++)
            {

                Console.WriteLine($" see thread   {Thread.CurrentThread.Name} ");

            }




        }
    }
}
