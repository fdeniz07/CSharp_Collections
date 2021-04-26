using System;
using System.Collections.Generic;

namespace GenericStackSinifi
{
    class Program
    {
        static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("Customer1 exist");
            }
            else
            {
                Console.WriteLine("Customer1 doesn't exist");
            }


            Customer c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " " + c1.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + " " + c2.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c3 = stackCustomers.Pop();
            Console.WriteLine(c3.ID + " " + c3.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c4 = stackCustomers.Pop();
            Console.WriteLine(c4.ID + " " + c4.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            Customer c5 = stackCustomers.Pop();
            Console.WriteLine(c5.ID + " " + c5.Name);
            Console.WriteLine("Items left in the stack = " + stackCustomers.Count);

            //foreach (Customer c in stackCustomers) --> Yukaridaki islemi foreach ile yapabiliriz ama eleman kaldiramayiz 
            //{
            //    Console.WriteLine(c1.ID + " " + c1.Name);
            //    Console.WriteLine("Items left in the stack = " + stackCustomers.Count);
            //}

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
