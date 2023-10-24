using System;

public class Agent
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Agent(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return "My name is " + LastName + ". " + FirstName + " " + LastName + ".";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Agent bond = new Agent("James", "Bond");
        Console.WriteLine(bond);

        Agent bourne = new Agent("Jason", "Bourne");
        Console.WriteLine(bourne);
    }
}
