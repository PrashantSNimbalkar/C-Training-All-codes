using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    class DemoDictonaryCustom
    {


     
            int Id;
            string Name;
            int Percentage;

            public DemoDictonaryCustom(int id, string name, int percentage)
            {
                Id = id;
                Name = name;
                Percentage = percentage;
            }


        public override bool Equals(object obj)
        {
            return obj is DemoDictonaryCustom custom &&
                   Id == custom.Id &&
                   Name == custom.Name &&
                   Percentage == custom.Percentage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Percentage);
        }




        static void Main(string[] args)
        {

            Dictionary<DemoDictonaryCustom, string> obj = new Dictionary<DemoDictonaryCustom, string>();


            obj.Add(new DemoDictonaryCustom(101,"Ajinkya", 100) , "CS");

            obj.Add(new DemoDictonaryCustom(102, "Ram", 100), "CS");


            foreach(KeyValuePair<DemoDictonaryCustom, String> kv in obj)
            {
                Console.WriteLine($"  {kv.Key}  {kv.Value}");
            }


        }


    }
}
