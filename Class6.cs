using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NewFolder
{

    interface IAnimal // interface is not class and it is fully abstract
    {
        void mymet();
    }


    class AC : IAnimal
    {
        public void mymet()
        {
            Console.WriteLine("Finally got it how it work");
        }
    }



    class Class6
    {
        static void Main(string[] args)
        {
            AC obj = new AC(); //we never create Interface object
            obj.mymet();

        }
    }
}
