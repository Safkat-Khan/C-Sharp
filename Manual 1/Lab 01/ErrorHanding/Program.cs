//HANDLING ERRORS USING TRY AND CATCH BLOCK

using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = 0;
            Console.Write("Please Enter your age: ");
            try
            {
                Age = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("User Age: " + Age);
            }
            catch (Exception)
            {
                Console.WriteLine("You must Enter a Numeric value as your age.");
            }
        }
    }
}
