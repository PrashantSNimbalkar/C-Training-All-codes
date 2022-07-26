using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.collection
{
    public class SBSort:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder x , StringBuilder y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class DemoSortedListCustomStringBuilder
    {
        static void Main(string[] args)
        {
           
            SortedList<StringBuilder, int> ss = 
                new SortedList<StringBuilder, int>(new SBSort()); //need to pass object of icompare

            ss.Add(new StringBuilder("Ajinkya"),100);
            ss.Add(new StringBuilder("Amit"), 90);
            ss.Add(new StringBuilder("Akash"), 90);
            ss.Add(new StringBuilder("Ashok"), 100);
            ss.Add(new StringBuilder("Aishwarya"), 100);

            ss.Add(new StringBuilder("Ammitabh"), 10);

            foreach (KeyValuePair<StringBuilder,int> kv in ss)
            {
                Console.WriteLine($"{kv.Key}  {kv.Value}");
            }


        }
    }
}
