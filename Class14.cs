using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{

    //14.	WAP to create a  Dictionary  using Custom class as key and any other object as value

    class Class14:IComparable<Class14>
    {

        int Id;
        string Name;

        public Class14(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(Class14 other)
        {
            return Id.CompareTo(other.Id);  // for acending
        }

        static void Main(string[] args)
        {

            Dictionary<Class14, long> dd = new Dictionary<Class14, long>();

            dd.Add(new Class14 (501 , "Ajinkya") , 9503756984);
            dd.Add(new Class14(502, "Shweta"), 8893756984);
            dd.Add(new Class14(503, "Neha"), 7803756984);
            dd.Add(new Class14(504, "Reshma"), 7703756984);
            dd.Add(new Class14(505, "Aayesha"), 8503756984);

        


            foreach (KeyValuePair<Class14 , long> x in dd)
            {
                Console.WriteLine($"{x.Key.Id} {x.Key.Name}    {x.Value}");
            }



        }


    }
}
