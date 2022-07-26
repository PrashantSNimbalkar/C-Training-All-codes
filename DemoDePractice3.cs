using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{


    public delegate void m(int a, int b);
    public delegate void m2(int a, int b);
    public delegate void m3(int a, int b);

    class DemoDePractice3
    {

        static void mym(int a, int b)
        {
            Console.WriteLine($"Addition is : {a+b}");
        }

        static void mym2(int a, int b)
        {
            Console.WriteLine($"Multiplication is : {a*b}");
        }

        static void mym3(int a, int b)
        {
            Console.WriteLine($"Substraction is :  {a-b}");
        }

        static void Main(string[] args)
        {

            m ob = DemoDePractice3.mym;

            ob(10,10);

            m2 ob2 = DemoDePractice3.mym2;
            ob2(20,10);

            m3 ob3 = DemoDePractice3.mym3;
            ob3(20,20);



        }
    }
}
