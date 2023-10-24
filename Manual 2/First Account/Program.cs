//Write a program that creates an account with a balance of 100.0, deposits 20.0 in it and finally prints the balance.

using System;

namespace BankAccountExample
{
    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a bank account with an initial balance of 100.0
            BankAccount account = new BankAccount(100.0);

            // Deposit 20.0 into the account
            account.Deposit(20.0);

            // Print the balance (should be 120.0)
            Console.WriteLine("Balance: " + account.GetBalance());
        }
    }
}
