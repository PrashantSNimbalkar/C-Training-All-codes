using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Tuples
{
    class DemoTuples
    {

        //creating tuple :  public static (touples type upto nth ex int item1 , int item 2...... n) methodname() {   }
        //Tuples Useful When u want to pass Multiple data type at a time 
        public static (int Empid, string Empname , string Eaddress) mymethod()
        {
           

            return (101, "Ajinkya", "Pune");
            
        } 



        static void Main(string[] args)
        {

            var x = mymethod();  //storing method return type in var x

            Console.WriteLine($"{x.Empid} {x.Empname} {x.Eaddress}");


        }
    }
}
