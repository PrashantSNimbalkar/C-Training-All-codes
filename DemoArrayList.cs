using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp1.collection
{
    class DemoArrayList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(10);
            al.Add(90);
            al.Add("Ajinkya");
            al.Add(10);
            al.Add(970);
            al.Add(140);
            al.Add(940);
            al.Add(130);
            al.Add(920);
            al[0] = "Ajinkya";
            al[5] = "Bangar";

            Console.WriteLine("Capacity = " +al.Capacity);
            Console.WriteLine("Count = " + al.Count);

            foreach (object s in al)
            {
                Console.WriteLine(s);
            }

        }
        


    }
}
