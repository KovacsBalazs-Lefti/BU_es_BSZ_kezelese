using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU_es_BSZ_kezelese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();

            Customer customer1 = new Customer("John Doe", 30, "123 Main St", "john@example.com", "555-123-4567");
            Customer customer2 = new Customer("Alice Smith", 25, "456 Elm St", "alice@example.com", "555-987-6543");

            // Ügyfelek hozzáadása a listához
            Customer.AddCustomerToList(customerList, customer1);
            Customer.AddCustomerToList(customerList, customer2);

            // Új ügyfelek
            Customer customer3 = new Customer("Eva Brown", 28, "789 Oak St", "eva@example.com", "555-567-8901");
            Customer customer4 = new Customer("Mike Johnson", 35, "321 Birch St", "mike@example.com", "555-234-5678");

            // Ügyfelek hozzáadása a listához
            Customer.AddCustomerToList(customerList, customer3);
            Customer.AddCustomerToList(customerList, customer4);

            // Kiírjuk az összes ügyfél adatait
            foreach (var customer in customerList)
            {
                customer.PrintCustomerInfo();
                Console.WriteLine(); // Üres sor
            }
            BankAccount account1 = new BankAccount("John Doe", 1000.00m, "12345", "Savings", new DateTime(2023, 1, 1), true);
            BankAccount account2 = new BankAccount("Alice Smith", 2000.00m, "67890", "Checking", new DateTime(2023, 1, 15), true);

            // Output Customer and BankAccount info
            customer1.PrintCustomerInfo();
            account1.PrintAccountInfo();
            Console.WriteLine();

            customer2.PrintCustomerInfo();
            account2.PrintAccountInfo();
            Console.WriteLine();

            // Perform some BankAccount operations
            account1.TransferFundsTo(account2, 500.00m);
            account1.CloseAccount();
            account2.UpdateAccountType("Premium");

            // Output updated account info
            account1.PrintAccountInfo();
            account2.PrintAccountInfo();


            Console.ReadLine();
        }
    }
}
