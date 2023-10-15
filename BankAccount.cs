using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BU_es_BSZ_kezelese
{
    internal class BankAccount
    {
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public DateTime AccountOpeningDate { get; set; }
        public bool IsAccountActive { get; set; }

        public BankAccount(string ownerName, decimal balance, string accountNumber, string accountType, DateTime accountOpeningDate, bool isAccountActive)
        {
            OwnerName = ownerName;
            Balance = balance;
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountOpeningDate = accountOpeningDate;
            IsAccountActive = isAccountActive;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Balance: {Balance:C2}"); // Currency format
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Opening Date: {AccountOpeningDate:yyyy-MM-dd}");
            Console.WriteLine($"Is Account Active: {IsAccountActive}");
        }

        public void CloseAccount()
        {
            IsAccountActive = false;
            Console.WriteLine("Account closed.");
        }

        public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
        {
            if (IsAccountActive && Balance >= amount)
            {
                Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine($"Transferred {amount:C2} to {destinationAccount.OwnerName}'s account.");
            }
            else
            {
                Console.WriteLine("Transfer failed. Either the account is not active or insufficient balance.");
            }
        }

        public void UpdateAccountType(string newAccountType)
        {
            AccountType = newAccountType;
            Console.WriteLine($"Account type updated to {newAccountType}.");
        }
    }
}
