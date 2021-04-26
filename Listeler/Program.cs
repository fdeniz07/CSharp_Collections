using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Listeler
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

            List < Customer > listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Customer[] CustomerArray = listCustomers.ToArray();

            foreach (Customer c in CustomerArray)
            {
                Console.WriteLine("ID={0},Name={1},Salary={2}",c.ID,c.Name,c.Salary);
            }
        }
       
    }
}
