using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU_es_BSZ_kezelese
{
    internal class Customer
    {
        public string CustomerName { get; private set; }
        public int CustomerAge { get; private set; }
        public string CustomerAddress { get; private set; }
        public string CustomerEmail { get; private set; }
        public string CustomerPhoneNumber { get; private set; }

        public Customer(string customerName, int customerAge, string customerAddress, string customerEmail, string customerPhoneNumber)
        {
            CustomerName = customerName;
            CustomerAge = customerAge;
            CustomerAddress = customerAddress;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine("Customer Information:");
            Console.WriteLine($"Name: {CustomerName}");
            Console.WriteLine($"Age: {CustomerAge}");
            Console.WriteLine($"Address: {CustomerAddress}");
            Console.WriteLine($"Email: {CustomerEmail}");
            Console.WriteLine($"Phone Number: {CustomerPhoneNumber}");
        }

        public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber)
        {
            CustomerName = newName;
            CustomerAge = newAge;
            CustomerAddress = newAddress;
            CustomerEmail = newEmail;
            CustomerPhoneNumber = newPhoneNumber;
            Console.WriteLine("Customer information updated.");
        }

        public void PlaceOrder(string product, int quantity)
        {
            Console.WriteLine($"{CustomerName} placed an order for {quantity} {product}(s).");
        }

        public void RequestSupport(string supportRequest)
        {
            Console.WriteLine($"{CustomerName} requested support: {supportRequest}");
        }

        public void SendFeedback(string feedback)
        {
            Console.WriteLine($"{CustomerName} sent feedback: {feedback}");
        }

        // Listához hozzáadás metódus
        public static void AddCustomerToList(List<Customer> customers, Customer customer)
        {
            customers.Add(customer);
            Console.WriteLine($"Customer {customer.CustomerName} added to the list.");
        }
    }
}
