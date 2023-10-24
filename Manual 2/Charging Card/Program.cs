using System;

namespace exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }

        public void EatLunch()
        {
            if (balance >= 10.60)
            {
                balance -= 10.60;
            }
        }

        public void DrinkCoffee()
        {
            if (balance >= 2.0)
            {
                balance -= 2.0;
            }
        }

        public void AddMoney(double amount)
        {
            // Increase the card's balance by the given amount
            balance += amount;

            // Limit the balance to a maximum of 150 euros
            if (balance > 150.0)
            {
                balance = 150.0;
            }
        }

        public override string ToString()
        {
            return "The card has a balance of " + balance.ToString("F2") + " euros";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(100);
            Console.WriteLine(card);

            card.AddMoney(49.99);
            Console.WriteLine(card);

            card.AddMoney(10000.0);
            Console.WriteLine(card);

            card.AddMoney(-10);
            Console.WriteLine(card);
        }
    }
}
