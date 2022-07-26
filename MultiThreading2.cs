using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1.MultiThreading
{
    class MultiThreading2
    {
        
        public void MM()
        {
            int J = 0;
            while (J < 10)
            {
                Console.WriteLine($" J =  {Thread.CurrentThread.Name}");
                J++;
            }

        }

       static void MM1()
        {
            int J = 0;
            while (J < 10)
            {
                Console.WriteLine($" K =  {Thread.CurrentThread.Name}");
                J++;
            }

        }




        static void Main(string[] args)
        {
            //Threading 

            Console.WriteLine("Ajinkya");
            Console.WriteLine("Ajinkya");
            Console.WriteLine("Ajinkya");
            Console.WriteLine("Ajinkya");


            MultiThreading2 obj = new MultiThreading2();

            Thread T1 = new Thread(obj.MM);
            T1.Start();
            T1.Name = "T1";
             Thread T2 = new Thread(MM1);
             T2.Start();
             T2.Name = "T2";
 

            int i = 0;
            while (i < 30)
            {
                Console.WriteLine($" I = {Thread.CurrentThread.Name} ");
                i++;
            }


        }
    }
}
