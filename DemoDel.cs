using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Deligate
{

   

    public delegate void mydele(string msg, string name);
    class DemoDel
    {
        static void greet(string msg, string name)
        {
            Console.WriteLine($"Message : {msg}     Name : {name}");
        }
        static void Main(string[] args)
        {

              mydele d1 = DemoDel.greet;

               d1("HEllo" ," Ajinkya");

            

        }
    }
}
