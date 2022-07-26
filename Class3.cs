using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Pratice_revision
{
    class Class3
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 60;

            //if else
            if (x > y)
            {
                Console.WriteLine( "X is Greater");
            }
            else
            {
                Console.WriteLine("Y is Greater");
            }

            Console.WriteLine("////////////////////////////////");

            if(100 < 200)
            {
                Console.WriteLine(200);
            }

            else
            {
                Console.WriteLine(100);
            }

            Console.WriteLine("////////////////////////////////");


            //else if 



            if(20>30)
            {
                Console.WriteLine("20");
            }

            else if(20<30)
                {
                Console.WriteLine(30);
            }

            else if ( 800==800)
            {
                Console.WriteLine(800);
            }
            else
            {
                Console.WriteLine("Else Block");
            }

            Console.WriteLine("//////////////////////////////");



            //ternery

            string ans = 20 > 30 ? "True if 20 is Greter" : 90 < 100 ? "True 100" : "btuut";

            Console.WriteLine(ans);


        }
    }
}
