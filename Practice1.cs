using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExcepyionHandling
{

    class a1
    {

        protected int A = 10;
        protected int B = 0;

        public int A1 { get => A; set => A = value; } // private to public using property

        public void M()
        {
            Console.WriteLine("Addition of two number is : " + A1 + B);
        }


    }


    class a2 : a1
    {
        public void M2()
        {
            Console.WriteLine("Multiplication of two number is : " + A1 * B);
        }

    }

    class a3 : a2
    {

        public void M3()
        {
            try
            {
                Console.WriteLine("Dividation of of two number is : " + A1 / B);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }

    
     
     }


    class Practice1
    {
          static void Main(string[] args)
        {
            a3 obj = new a3();
            obj.M();
            obj.M2();
            obj.M3();
        }
    }
}
