using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExcepyionHandling
{


    class LowbalEXP :SystemException
    {
       public  LowbalEXP():base("Balanc is low")
        {

        } 
    }


      class CustomException
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Withrow Balance");
            int bal = int.Parse(Console.ReadLine());

            LowbalEXP m = new LowbalEXP();

            try
            {
                if (bal >= 500)
                
                    Console.WriteLine(" Balance is More than 500 ");
                

            }
            catch (LowbalEXP e)
            {
                Console.WriteLine(e.Message);
            }



            finally
            {
                Console.WriteLine("code finished");
            }


        }
    }
}
