using System;

public class Multiplier
{
    private int number; // Instance variable to store the number provided in the constructor

    public Multiplier(int number)
    {
        this.number = number;
    }

    public int Multiply(int number)
    {
        // Multiply the provided number by the instance variable and store the result
        int result = this.number * number;
        this.number = result; // Update the instance variable
        return result;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Multiplier multiplyByThree = new Multiplier(3);
        Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

        Multiplier multiplyByFour = new Multiplier(4);
        Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));

        Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
        Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
        Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
    }
}
