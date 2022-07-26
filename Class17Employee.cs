using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //17.	WAP to create a LinkedList<Emp>
    //and search for Emp object whose eno=10
    //and delete all the records whose dept is same as  eno 10.Emp(int id, String name Dept d)

    class Dept
    {
        string Dname;

        public Dept(string dname)
        {
            this.dname = dname;
        }
        public string dname { get; set; }

    }
    class Class17Employee
    {
        int id;
        string ename;
        Dept d;

        public int Id { get => id; set => id = value; }
        public string Ename { get => ename; set => ename = value; }
        public Dept D { get => d; set => d = value; }

        public Class17Employee(int id, string ename, Dept d)
        {
            this.Id = id;
            this.Ename = ename;
            this.D = d;
        }

        public override string ToString()
        {
            return $"Id {Id} Ename {Ename} Deptname {d.dname}";
        }

        static void Main(string[] args)
        {

            LinkedList<Class17Employee> ll = new LinkedList<Class17Employee>();

            ll.AddLast(new Class17Employee(101, "AA", new Dept("It")));
            ll.AddLast(new Class17Employee(102, "BB", new Dept("Sales")));
            ll.AddLast(new Class17Employee(103, "CC", new Dept("Test")));
            ll.AddLast(new Class17Employee(104, "DD", new Dept("It")));
            ll.AddLast(new Class17Employee(105, "EE", new Dept("It")));

            string dname = "";

            foreach (Class17Employee e in ll)
            {
                if (e.id == 101)
                {
                    dname = e.d.dname;
                    break;
                }
                
            }

            foreach (Class17Employee ee in ll)
            {
                Console.WriteLine(ee);
            }

            Console.WriteLine("*******************");

            for (int i = 0; i < ll.Count; i++)
            {
                Class17Employee ob = ll.ElementAt(i);

                if (ob.d.dname == dname)
                {
                    ll.Remove(ob);
                }
            }

            for (int i = 0; i < ll.Count; i++)
            {
                Console.WriteLine(ll.ElementAt(i));
            }
        }
    }
}
