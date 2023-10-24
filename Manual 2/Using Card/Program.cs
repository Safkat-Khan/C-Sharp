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
            balance -= 10.60;
        }

        public void DrinkCoffee()
        {
            balance -= 2.0;
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
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}
