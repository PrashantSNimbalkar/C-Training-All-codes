using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tuples
{
    class DemoTuples2
    {

        public static (int sid , string sname , int mark ,string location) methodstud()
        {
            return (101, "Ajinkya", 100 , "Pune");
        }
        static void Main(string[] args)
        {

           var x = methodstud();


            Console.WriteLine($"Student ID : {x.sid}   Name : {x.sname}   Mark : {x.mark}   Location : {x.location}");
        }
    }
}
