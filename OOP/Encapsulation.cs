using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankAccount
    {
        public string AccountHolder { get; }
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public BankAccount(string holder, double initialBalance)
        {
            AccountHolder = holder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposit successful! New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful! Remaining balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }
    }
}
