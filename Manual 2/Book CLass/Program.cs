using System;
using System.Collections.Generic;

namespace BookInformation
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int pages, int year)
        {
            Title = title;
            Pages = pages;
            PublicationYear = year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Enter book title : ");
                string title = Console.ReadLine();

                if (string.IsNullOrEmpty(title))
                {
                    break;
                }

                Console.Write("Enter the number of pages: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Enter the publication year: ");
                int year = int.Parse(Console.ReadLine());

                Book book = new Book(title, pages, year);
                books.Add(book);
            }

            Console.Write("What would you like to print ? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "everything":
                    Console.WriteLine("Books information:");
                    foreach (var book in books)
                    {
                        Console.WriteLine($"{book.Title}, {book.Pages} pages, published in {book.PublicationYear}");
                    }
                    break;

                case "title":
                    Console.WriteLine("Book titles:");
                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Title);
                    }
                    break;

                default:
                    Console.WriteLine("Nothing will be printed.");
                    break;
            }
        }
    }
}
