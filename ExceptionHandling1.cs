using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExcepyionHandling
{
    class ExceptionHandling1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number");
                int x = int.Parse(Console.ReadLine());
                
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Check And Enter Correct Number");
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter Correct Number");
            }

            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }



            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}
