using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate.PracticeDeligate
{

    public delegate void D(string a);
    class DeligateLambda2
    {
        static void Main(string[] args)
        {

            D obj = (a) => { Console.WriteLine($"Hello {a}"); };

            obj = obj += (a) => { Console.WriteLine($"Hey {a} Its Call Multiple Function or method at a time "); };


            obj("Ajinkya");

        }
    }
}
