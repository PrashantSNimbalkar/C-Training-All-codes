using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{

  


        interface IA
        {
            void met();
        } 



        interface IB
        {
            void mymet2();
        }





        class v : IA,IB
        {
            public void met()
            {
                Console.WriteLine("GOTTTTTTTTTTTTTTT ITTTTTT");
            }

            public void mymet2()
            {
                Console.WriteLine("Finally");
            }



        }




    class Class7
    {
        static void Main(string[] args)
        {
            v obj = new v();
            obj.mymet2();
            obj.met();
        }
    }
}
