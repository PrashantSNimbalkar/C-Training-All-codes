using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.collection
{
    class Student:IComparable<Student>
    {
        int Id;
        int Percentage;
        string Qualification;
        string Name;

        public Student(int id,string name, string qualification, int percentage)
        {
            Id = id;
            Percentage = percentage;
            Name = name;
            Qualification = qualification;
        }

        public override string ToString()
        {
            return $"Id {Id}  Name {Name} Qualification {Qualification} Percentage {Percentage}";
        }


        //IComparable<Student>    interface abstract class CompareTo compulsury need to use 
        public int CompareTo(Student other) //return type int 0 1 -1
        {
         //   return Percentage.CompareTo(other.Percentage);  // for acending

            return other.Percentage.CompareTo(Percentage);  // for decending
        }





        static void Main(string[] args)
        {
             List<Student> slist = new List<Student>();
            slist.Add(new Student(1,"Ajinkya", "CS", 100));
            slist.Add(new Student(2,"Neha", "BE", 90));
            slist.Add(new Student(3,"Shweta","CS", 80));
            slist.Add(new Student(4, "Anu","BCA", 100));
            slist.Add(new Student(5, "Ritik","BCS", 90));
            slist.Add(new Student(6, "Titiksha","ENTC", 50));
            slist.Add(new Student(7, "Snehal","ENTC", 70));
            slist.Add(new Student(8, "Deepti","CS", 50));
           

            slist.Sort();


            slist.ForEach(ss => Console.WriteLine(ss));




           /* foreach (Student s in slist)
            {
                Console.WriteLine($"{s.Id} {s.Name}            {s.Qualification}          {s.Percentage}");
            }*/


        }

       
    }
}
