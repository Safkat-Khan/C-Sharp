using System;

public class Dalmatian
{
    public string Name { get; set; }
    public int Spots { get; set; }

    public Dalmatian(string name, int spots)
    {
        Name = name;
        Spots = spots;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dalmatian spotty = new Dalmatian("Spot", 306);
        Console.WriteLine(spotty.Name + " is a very good dog. He has " + spotty.Spots + " darker spots in his fur.");
    }
}
