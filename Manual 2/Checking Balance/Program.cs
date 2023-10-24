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
            // Check if there's enough money to eat lunch
            if (balance >= 10.60)
            {
                balance -= 10.60;
            }
        }

        public void DrinkCoffee()
        {
            // Check if there's enough money to drink coffee
            if (balance >= 2.0)
            {
                balance -= 2.0;
            }
        }

        public override string ToString()
        {
            return "The card has a balance of " + balance + " euros";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}
