using System;
using System.Collections.Generic;

namespace ComparisonDelegate
{
    class Program
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500
            };

            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer3);
            listCustomers.Add(customer2);

            //1. Kullanim (Orjinal delegate'i metod icerisinde cagirmak
            //Comparison<Customer> customerCompare = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomers)
            { 
                Console.WriteLine(c.ID); 
            }

            //2. Kullanim : Dogrudan delegate'i kullanmak
            //listCustomers.Sort(delegate (Customer c1, Customer c2) { return c1.ID.CompareTo(c2.ID); });

            //3. Kullanim : Linq Expression kullanmak
            listCustomers.Sort((x, y) =>x.ID.CompareTo(y.ID));
            
            //1. Kullanim (Orjinal delegate'i metod icerisinde cagirmak
            //listCustomers.Sort(CompareCustomer);

            Console.WriteLine("After sorting");
            foreach (Customer c in listCustomers)
            { 
                Console.WriteLine(c.ID); 
            }

        }
        //1. Kullanim (Orjinal delegate'i metod icerisinde cagirmak
        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //    return x.ID.CompareTo(y.ID);
        //}
    }
}
