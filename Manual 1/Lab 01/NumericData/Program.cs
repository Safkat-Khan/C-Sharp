//TAKING NUMERIC DATA IN CONSOLE APPLICATION

using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            Console.Write("Please Enter your age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("User Age: " + Age);
        }
    }
}
