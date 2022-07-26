using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DelegateLambda
{
    class ReadyMade
    {
        static string greet()
        {
            return "Good Morning Have A NIce Day";
        }
        static int multi(int x , int y ,int z)
        {
            return x * y * z;
        }

        static bool iseven(int x)
        {
            return x % 2 == 0; // returning True Or False
        }

        static void add(int j ,int k)
        {
            Console.WriteLine(j+k);
        }
       

        static void Main(string[] args)
        {


            Func<string> d1 = greet;
           
           
           

            Func<int, int,int, int> d2 = (a, b,c) => a * b * c;

            Console.WriteLine($"Multi is ={d2(10,20,30)}");




/*
            Action<int , int> d3 = (x,y) => //using lambda
             Console.WriteLine($"Addition is {x+y}");
            d3(10, 50);*/

            Action<int, int> d7 = add;
            d7(10, 50);



            Predicate<int> d5 = iseven;
            bool bb = d5(78);
            Console.WriteLine(bb);


        }
    }
}
