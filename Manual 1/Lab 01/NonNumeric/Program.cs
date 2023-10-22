//TAKING NON-NUMERIC DATA FROM KEYBOARD INTO CONSOLE APPLICATION

using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            Console.Write("Please Enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("User Name: " + Name);
        }
    }
}
