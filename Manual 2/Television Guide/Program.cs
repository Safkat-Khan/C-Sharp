using System;
using System.Collections.Generic;

namespace TelevisionPrograms
{
    public class TelevisionProgram
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public TelevisionProgram(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Name} ({Duration} minutes)";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<TelevisionProgram> programs = new List<TelevisionProgram>();

            while (true)
            {
                Console.Write("Program name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    break; 
                }

                Console.Write("Program duration (in minutes): ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                {
                    programs.Add(new TelevisionProgram(name, duration));
                }
                else
                {
                    Console.WriteLine("Invalid duration. Please enter a valid number.");
                }
            }

            Console.Write("\nEnter the maximum duration (in minutes): ");
            if (int.TryParse(Console.ReadLine(), out int maxDuration))
            {
                foreach (TelevisionProgram program in programs)
                {
                    if (program.Duration <= maxDuration)
                    {
                        Console.WriteLine(program);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid maximum duration. Please enter a valid number.");
            }
        }
    }
}
