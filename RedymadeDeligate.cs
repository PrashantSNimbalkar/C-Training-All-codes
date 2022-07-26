using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate.PracticeDeligate
{
    class RedymadeDeligate
    {

      static int add(int a , int b)
        {
            return a + b;
        }

        static void mul(int x , int y)
        {
            Console.WriteLine(x*y);
        }

        static bool B(int a )
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }




       




        static void Main(string[] args)
        {
            Func<int, int, int> obj = add;
            int c = obj(10,60);
            Console.WriteLine(c);


            Action<int, int> objAction = mul;
              objAction(10,60);


            Predicate<int> objPredicate = B;
            bool x = objPredicate(2);
            Console.WriteLine(x);
        }
    }
}
