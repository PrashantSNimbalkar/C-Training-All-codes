using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assigntment1
{
/*    17.	WAP to check Exception handling with method overriding.Means, If super class method don’t
declare exception then subclass overridden method can declare exception or not.
*/


    class one
    {
        public  virtual void MyM()
        {
            Console.WriteLine("Its Virtual ");
        }

    }

    class two:one
    {
        public  override void MyM()
        {
            Console.WriteLine("Its Overriden ");
        }
    }



    class Class17
    {
        static void Main(string[] args)
        {
            one Obj = new two();
            Obj.MyM();


        }
    }
}
