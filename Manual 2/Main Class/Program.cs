using System;
using System.Collections.Generic;

namespace ItemList
{
    public class Item
    {
        public string Name { get; }
        public DateTime CreatedAt { get; }

        public Item(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name} (created at: {CreatedAt:dd.MM.yyyy HH.mm.ss})";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    break; 
                }

                Item newItem = new Item(name);
                items.Add(newItem);
            }


            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
