using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class Product
    {
        int Pid;
        string Pname;
        int Price;

        public Product(int pid , string pname , int price)
        {
            this.Pid = pid;
            this.Pname = pname;
            this.Price = price;
        }


        
        static void Main(string[] args)
        {
            Queue<Product> lst = new Queue<Product>();

            lst.Enqueue(new Product(101 , "Bajaj Room Heater" , 2200));
            lst.Enqueue(new Product(102 , "Usha Room Heater" , 2300));
            lst.Enqueue(new Product(103, "LG Room Heater", 3200));
            lst.Enqueue(new Product(104, "Samsung Room Heater", 4300));
            lst.Enqueue(new Product(105, "LG Room Heater", 3200));
            lst.Enqueue(new Product(106, "Usha Room Heater", 2300));
         


            foreach (Product i in lst)
            {
                Console.WriteLine($" Product Id : {i.Pid} Product Name : {i.Pname} Price : {i.Price}");
            }






        }
    }
}
