using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DelegateP
{
    class DemoDelegate
    {
        public delegate void mydelegate(int x);
        public void square(int a)   //instatnce
        {
            Console.WriteLine("Square "+ a*a);
        }


        
        
        public delegate void mydelegate2(int x,int y);

        static void add(int v , int j)   //static
        {
            Console.WriteLine($"Add is {v+j}");
        }

        static void Main(string[] args)
        {
        //instance delegate calling
            DemoDelegate ob = new DemoDelegate();

            mydelegate d1 = ob.square;

            d1(7);


            //static delegate calling

            mydelegate2 d2 = add;

            d2(10,20);


        }

    }






    class Demo2               
    {
        public delegate int Mydelegate3(int x);
        public static int Factorial(int a)
        {
            int f = 1;

            for(int i = 1; i<=a;i++)
            {
                f = f * i;
            }
            return f;
        }

        static void Main(string[] args)
        {
            Mydelegate3 d3 = Factorial;

               Console.WriteLine(d3(3));
        }

    }




    class Demo3
    {

        public delegate void mydelegate(int x);
        public void square(int a)   //instatnce
        {
            Console.WriteLine("Square " + a * a);
        }

       
        public void doubleup(int b)   //instatnce
        {
            Console.WriteLine($"double up {b+b}");
        }

        public void cube(int c)   //instatnce
        {
            Console.WriteLine($"Cube {c*c*c}");
        }

      

        public static void print(int v)
        {
            Console.WriteLine($"print {v}");
        }



      




        static void Main(string[] args)
        {
            Demo3 obj = new Demo3();

            mydelegate d = obj.square;

            d = d + obj.doubleup; // stroing multiple using d=d+obj.doubleup

            d = d + obj.cube;// stroing multiple using d=d+obj.doubleup

            d = d + Demo3.print; //calling static 


            d(5);


        }




             

        }
    }






   