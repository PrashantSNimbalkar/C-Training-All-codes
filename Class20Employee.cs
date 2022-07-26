using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    class Class20Employee:IComparable<Class20Employee>
    {
        //20.	Create  a SortedList<Emp,string>  where key is emp object and value is deptname he works in.
        //Sort According to employee salary and if two employees have same salary than according to name.


        string EmpName;
        long Salary;

        public Class20Employee(string empName, long salary)
        {
            EmpName = empName;
            Salary = salary;
        }




        public int CompareTo( Class20Employee other)
        {
            //   return Salary.CompareTo(other.Salary);  // for acending

            return other.Salary.CompareTo(Salary);  // for decending
        }



        static void Main(string[] args)
        {
            SortedList<Class20Employee, string> sl = new SortedList<Class20Employee, string>();


            sl.Add(new Class20Employee ("Ajinkya" , 999999) , "IT");
            sl.Add(new Class20Employee("Prasad", 899999), "IT");
            sl.Add(new Class20Employee("Shweta", 25000 ), "KPO");
            sl.Add(new Class20Employee("Saket", 35000), "HR");
            sl.Add(new Class20Employee("Sneha", 5000), "Recruitment");


            foreach (KeyValuePair<Class20Employee,string> x in sl)
            {
                Console.WriteLine($"Name : {x.Key.EmpName}  Salary : {x.Key.Salary}  {x.Value}");
            }


        }

      
    }
}
