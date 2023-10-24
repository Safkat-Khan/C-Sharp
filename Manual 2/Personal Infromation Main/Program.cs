using System;
using System.Collections.Generic;

namespace PersonalInformation
{
    public class PersonalInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationNumber { get; set; }

        public PersonalInformation(string firstName, string lastName, string idNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            IdentificationNumber = idNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonalInformation> people = new List<PersonalInformation>();

            while (true)
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine();

                if (string.IsNullOrEmpty(firstName))
                {
                    break; 
                }

                Console.Write("Last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Identification number: ");
                string idNumber = Console.ReadLine();

                people.Add(new PersonalInformation(firstName, lastName, idNumber));

                Console.WriteLine(); 
            }

            Console.WriteLine("\n--- Personal Information ---");
            foreach (PersonalInformation person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }
    }
}
