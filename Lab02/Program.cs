//USING "IF" AND "ELSE" TO DEFINE CONDITIONS IN C# APPLICATIONS
//This program takes a name as input which should be 10 characters long. If not then it will display an error message.

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
            else Console.WriteLine("User Name: " + Name);
        }
    }
}

//PUTTING COMMENTS IN C# CODE

class Program
{
    static void Main(string[] args)
    {
        string Name = ""; Console.Write("Please enter your name: ");
        // You can put a single line comment
        // /* or, if you wish,
        // * you can put a multiple line comment
        //* like this * */
    }
}


//USING FOR LOOP

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
            Console.Write(i);
    }
}

