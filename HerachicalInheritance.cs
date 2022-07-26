using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class HerachicalInheritance
    {
        public void m()
        {
            Console.WriteLine("M");
        }
    }

    class x : HerachicalInheritance
    {
        public void m2()
        {
            Console.WriteLine("M2 of x");
        }
    }

    class y : HerachicalInheritance
    {
        public void m3(int x)
        {
            Console.WriteLine("M3 of y" + x);
        }
    }

    class run9
    {
        static void Main(string[] args)
        {
            y obj = new y();
            obj.m3(10);


            x obj2 = new x();
            obj2.m2();

            obj.m();
        }
    }

}
