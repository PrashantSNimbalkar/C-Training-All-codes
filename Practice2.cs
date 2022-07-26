using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExcepyionHandling
{
    class Practice2
    {






        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter Withdrowal Ammount : ");
            int amt = int.Parse(Console.ReadLine());

           
                if (amt >= 2000)
                {
                    Console.WriteLine($"Withdrowl Amount {amt} is Lsess Than Your Balance");

                }

                else
                {
                    int rem = 2000 - amt;
                    Console.WriteLine("Remaning Bal is : " + rem);

                }

            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Code Finish \n Thank You");
            }

        }
    }
}
