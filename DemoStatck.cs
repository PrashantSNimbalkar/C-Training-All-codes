
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoStatck
    {

        static void Main(string[] args)
        {

            Stack<int> st = new Stack<int>();
             //LIFO
            st.Push(10);
            st.Push(20);
            st.Pop(); //removing 20
            st.Push(30);
            st.Push(40);
            st.Push(50);
            st.Push(60);  //adding
            Console.WriteLine("See whos on peek : " + st.Peek());  //showingg whos on top of statck


            foreach (int item in st)
            {
                Console.WriteLine(item);

            }





        }
    }
}
