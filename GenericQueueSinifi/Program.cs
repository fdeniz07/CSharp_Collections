using System;
using System.Collections.Generic;

namespace GenericQueueSinifi
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

            //Kullanimi List e benzer
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("Customer1 exist");
            }
            else
            {
                Console.WriteLine("Customer1 doesn't exist");
            }


            /*Dequeue() ve Peek() metodu arasındaki farklar
              Dequeue() metodu kuyruğun en başındaki elemanı kaldırır ve tekrar o elemanı döndürür. Öte yandan Peek() metodu kuyruğun en başındaki elemanı kaldırmadan, ilk elemanı döndürür.
            */

            Customer c3 = queueCustomers.Peek(); // Siranin basindakini kaldirmaz
            Console.WriteLine(c3.ID + " " + c3.Name);
            Console.WriteLine("Total Items in the Queue = " + " " + queueCustomers.Count);

            Customer c1 = queueCustomers.Dequeue(); // Siranin basindakini kaldirir
            Console.WriteLine(c1.ID + " - " + c1.Name);
            Console.WriteLine("Total Items in the Queue = " + " " + queueCustomers.Count); // Sirada kalan sayisi

            Customer c2 = queueCustomers.Peek(); // Siranin basindakini kaldirmaz
            Console.WriteLine(c2.ID + " " + c2.Name);
            Console.WriteLine("Total Items in the Queue = " + " " + queueCustomers.Count);
        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
