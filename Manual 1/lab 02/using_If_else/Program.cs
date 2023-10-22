//USING "IF" AND "ELSE" TO DEFINE CONDITIONS IN C# APPLICATIONS

using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();

            if (Name.Length > 10)
                Console.WriteLine("Name must be within 10 characters.");
            else
                Console.WriteLine("User Name: " + Name);
        }
    }
}
