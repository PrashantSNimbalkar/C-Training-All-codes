using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {



            string str1;
            char[] arr1;
            int l, i;
            l = 0;
            Char ch;

            str1 = Console.ReadLine();
            l = str1.Length;

            arr1 = str1.ToCharArray(0, l);

            for (i = 0; i < l; i++)
            {
                ch = arr1[i];

                if (char.IsLower(ch))
                {
                    Console.Write(Char.ToUpper(ch));
                }
                else
                    Console.Write(Char.ToLower(ch));
            }

        }


    }
}