using ConsoleApp1.collection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //10.	WAP to create a class Employee with (name, designation and age)
    //.Now create and add Employee objects elements to List.
    //Sort the List by age in descending order and print List.
  
    
    class EmployeeClass10: IComparable<EmployeeClass10>
    {

        string Name;
        string Designation;
        int age;



        public EmployeeClass10(string name, string designation, int age)
        {
            Name = name;
            Designation = designation;
            this.age = age;
        }

        public int CompareTo(EmployeeClass10 other) //return type int 0 1 -1
        {
            //   return age.CompareTo(other.age);  // for acending

            return other.age.CompareTo(age);  // for decending
        }

      





        static void Main(string[] args)
        {

            List<EmployeeClass10> ll = new List<EmployeeClass10>();

            ll.Add(new EmployeeClass10 ("Ajinkya" , "Manager" , 24));
            ll.Add(new EmployeeClass10("Prasad", "Software Devloper", 25));
            ll.Add(new EmployeeClass10("Saket", "Software Devloper", 28));
            ll.Add(new EmployeeClass10("Shweta", "Ux Devloper", 27));
            ll.Add(new EmployeeClass10("Neha", "Ui Devloper", 25));

            ll.Sort();

            foreach (EmployeeClass10 x in ll)
            {
                Console.WriteLine($"Employee Name : {x.Name}  Designation : {x.Designation}  Age : {x.age}");
            }


        }

       
    }
}
