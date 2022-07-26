using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    class singleinher
    {
       protected int x = 10;

        public void mym()
        {
            Console.WriteLine(x);
        }
    }

    class mul : singleinher
    {
        public void my()
        {
            Console.WriteLine("Ajinkya" + x);
        }
    }

    class run7
    {
        static void Main(string[] args)
        {
            mul obj = new mul();
            obj.my();
            obj.mym();
        }
    }

}
