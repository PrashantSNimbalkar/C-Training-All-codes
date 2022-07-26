using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

    public delegate string del(string a);
    class DemoDePractice6
    {


        static string m(string a)
        {
            return a;
        }



        static void Main(string[] args)
        {

            del obj = DemoDePractice6.m;

          string a =  obj("kk");
            Console.WriteLine(a);
             
        }
    }
}
