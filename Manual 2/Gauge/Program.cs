using System;

public class Gauge
{
    public int Value { get; set; }

    public Gauge()
    {
        Value = 0;
    }

    public void Increase()
    {
        if (Value < 5)
        {
            Value++;
        }
    }

    public void Decrease()
    {
        if (Value > 0)
        {
            Value--;
        }
    }

    public bool Full()
    {
        return Value == 5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gauge g = new Gauge();

        while (!g.Full())
        {
            Console.WriteLine("Not full! Value: " + g.Value);
            g.Increase();
        }

        Console.WriteLine("Full! Value: " + g.Value);

        g.Decrease();
        Console.WriteLine("Not full! Value: " + g.Value);
    }
}
