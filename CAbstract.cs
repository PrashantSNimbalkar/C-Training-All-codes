using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{
    abstract class CAbstract
    {
        public abstract void mym(); 

       
    }

    class a1 : CAbstract
    {
        public override void mym()
        {
            Console.WriteLine("Abstract Method");
        }
    }
    

    class run10
    {
        static void Main(string[] args)
        {
            a1 obj = new a1();
            obj.mym();
        }
    }

}
