using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class Employee
    {

        int Eid;
        string Name;
        long Mobile;

        public Employee(int id , string name , int mobile)
        {
            this.Eid = id;
            this.Name = name;
            this.Mobile = mobile;
        }



        static void Main(string[] args)
        {

            Stack<Employee> sl = new Stack<Employee> ();

            sl.Push(new Employee (101 , "Ajinkya" , 78600648 ) );
            sl.Push(new Employee(102, "Amruta", 89600648));
            sl.Push(new Employee(103, "Radha", 45600648));
            sl.Push(new Employee(104, "Krishna", 66600648));
            sl.Push(new Employee(105, "Govind", 78600648));
            sl.Push(new Employee(106, "Hari", 98600648));
            sl.Push(new Employee(107, "Murai", 78600648));
            sl.Push(new Employee(108, "Ram", 25400648));
            sl.Push(new Employee(109, "Narayna", 11600648));
            sl.Push(new Employee(110, "Vasudeva", 22600648));



            foreach (Employee item in sl)
            {
                Console.WriteLine($" ID : {item.Eid} Name : {item.Name}  Mobile : {item.Mobile}   ");
            }


        }
    }
}
