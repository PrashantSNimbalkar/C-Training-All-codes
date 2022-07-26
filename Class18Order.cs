using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CollectionAssigntment
{
    //18.	Flipkart maintains a list<order> from different places .Order has (orderid,city,itemname,status).
    //From this create a Dictionary which stores key has cityname and count as no of order’s pending in that city.
    //Data should be sorted according to city.



    
 class Class18Order
    {
            int orderid;
            string itemname;
            string city;
            string status;

            public Class18Order(int orderid, string itemname, string city, string status)
            {
                this.orderid = orderid;
                this.itemname = itemname;
                this.city = city;
                this.status = status;
            }


            static void Main(string[] args)
            {

                List<Class18Order> ol = new List<Class18Order>();
                ol.Add(new Class18Order(101, "Laptop", "Pune", "Delivered"));
                ol.Add(new Class18Order(102, "Desktop", "Pune", "Delivered"));
                ol.Add(new Class18Order(103, "Mouse", "Nashik", "Pending"));
                ol.Add(new Class18Order(104, "Keyboard", "Mumbai", "Pending"));
                ol.Add(new Class18Order(105, "TV", "Satara", "Delivered"));


                Dictionary<string, int> dd = new Dictionary<string, int>();

                foreach (Class18Order x in ol)
                {


                    if (x.status == "Pending")
                    {
                        if (dd.ContainsKey(x.city))
                        {
                            int oldval = dd[x.city];
                            dd[x.city] = oldval + 1;
                        }
                        else
                        {
                            dd.Add(x.city, 1);
                        }


                    }
                }


                foreach (KeyValuePair<string, int> kv in dd)
                {
                    Console.WriteLine($"{kv.Key}        {kv.Value}");
                }


            }
        }
    }

