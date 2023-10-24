using System;

public class Product
{
    private string name;
    private double price;
    private int quantity;

    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name}: price {price:F1}: {quantity} pcs");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Product banana = new Product("Banana", 1.1, 13);
        banana.PrintProduct(); 
    }
}
