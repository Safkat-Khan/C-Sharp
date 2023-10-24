using System;

namespace BankAccountExample
{
    class BankAccount
    {
        private double balance;
        private string accountName;

        public BankAccount(string name, double initialBalance)
        {
            accountName = name;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds to withdraw " + amount);
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return  accountName + " Balance: " + balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Heikki's account with a balance of 1000.0
            BankAccount heikkisAccount = new BankAccount("Heikki's account", 1000.0);

            // Create Personal account with a balance of 0.0
            BankAccount personalAccount = new BankAccount("Personal account", 0.0);

            // Withdraw 100.0 from Heikki's account
            heikkisAccount.Withdraw(100.0);

            // Deposit 100.0 to Personal account
            personalAccount.Deposit(100.0);

            // Print account information using ToString
            Console.WriteLine(heikkisAccount.ToString());
            Console.WriteLine(personalAccount.ToString());
        }
    }
}
