using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ExceptionHandling
{
    class CustomException2:ApplicationException
    {

        public  CustomException2()
        {

        }


        public CustomException2(string msg):base(msg)
        {

        }
    }

    class studd
    {
        string username;
        string password;

        public string Username
        {
            set { this.username = value; }
            get { return username; }
        }
        public string Password {
            set
            {
                if (value.Length <= 5)
                    throw new InvalidPasswordException("Password Length should be greeater than 5");

                else
                    this.password = value;
            }

            get { return password; }
        }



        static void Main(string[] args)
        {
            studd s1 = new studd();
            s1.Username = "Riya";
            try
            {
                s1.Password = "abcd";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Ends");
        }
    }
   
    }

