using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class multileveInher
    {
        protected int z = 20;

        public void m()
        {
            Console.WriteLine(z + "m");
        }
    }

        class a : multileveInher
        {
            public void m2()
            {
                Console.WriteLine(z + "m2");
            }
        }

        class b :a
        {
            public void m3()
            {
                Console.WriteLine(z+"m3");
            }
        }
    
    class run8
    {
        static void Main(string[] args)
        {
            b obj = new b();
     

            obj.m3();
            obj.m2();
            obj.m();

        }
    }

}
