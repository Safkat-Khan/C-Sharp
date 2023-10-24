using System;

public class Debt
{
    private double balance;
    private double interestRate;

    public Debt(double initialBalance, double initialInterestRate)
    {
        balance = initialBalance;
        interestRate = initialInterestRate;
    }

    public void PrintBalance()
    {
        Console.WriteLine(balance);
    }

    public void WaitOneYear()
    {
        balance *= interestRate;
    }

    public static void Main(string[] args)
    {
        Debt mortgage = new Debt(120000.0, 1.01);

        mortgage.PrintBalance(); 

        mortgage.WaitOneYear();
        mortgage.PrintBalance(); 

        // Wait 20 years
        int years = 0;
        while (years < 20)
        {
            mortgage.WaitOneYear();
            years = years + 1;
        }

        mortgage.PrintBalance(); 
    }
}
