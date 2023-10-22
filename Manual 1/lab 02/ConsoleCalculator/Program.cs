//CREATING A SIMPLE CONSOLE CALCULATOR


using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first Number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second Number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            double result = 0;
            bool valid = true;

            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n2 != 0)
                        result = n1 / n2;
                    else
                        valid = false;
                    break;
                default:
                    valid = false;
                    break;
            }

            if (valid)
                Console.WriteLine("Result is: " + result);
            else
                Console.WriteLine("Invalid Operator or division by zero!");
        }
    }
}
