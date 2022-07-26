using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate.PracticeDeligate
{
    class RedymadeDeligate2
    {

        static string st(string a)
        {
            return a;
        }



        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }


        static bool Ev(int a)
        {
            if (a == 10)
            {
                return true;
            }
            else
                return false;
        }


        static void Main(string[] args)
        {

            Func<string,string> objFunc = st;
            string x = objFunc("Ajinkya");
            Console.WriteLine(x);


            Action<int, int> objAction = Add;
            objAction(10,30);

            Predicate<int>  objPredicate = Ev;
            bool cc = objPredicate(10);
            Console.WriteLine(cc);
        }
    }
}
