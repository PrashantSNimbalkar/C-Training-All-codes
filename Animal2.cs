using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class Animal2
    {
        private int a = 10;
       private  int x = 20;

        public int A { get => a; set => a = value; } // write property for using encasulated data
        public int X { get => x; set => x = value; }



    }

    class run5
    {
        static void Main(string[] args)
        {
            Animal2 obj = new Animal2();
            Console.WriteLine(obj.A + "as well as " + obj.X ) ;

        }
    }


}
