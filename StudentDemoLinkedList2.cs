using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class StudentDemoLinkedList2
    {

      

            int Sid;
            string Name;
            int Percentage;

            public StudentDemoLinkedList2(int id, string name, int Percentage)
            {
                this.Sid = id;
                this.Name = name;
                this.Percentage = Percentage;
            }
     


            static void Main(string[] args)
            {
                LinkedList<StudentDemoLinkedList2> obj = new LinkedList<StudentDemoLinkedList2>();

                obj.AddFirst(new StudentDemoLinkedList2(101, "Ajinkya", 99));

                obj.AddFirst(new StudentDemoLinkedList2(103, "Ajinkya", 99));
                obj.AddFirst(new StudentDemoLinkedList2(102, "Rahul", 95));



            foreach (StudentDemoLinkedList2 item in obj)
            {
                Console.WriteLine($" ID : {item.Sid} Name : {item.Name}  Percentage : {item.Percentage}   ");
            }





        }

        }
    }

