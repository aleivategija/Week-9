using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Downloads\samples";
            Console.WriteLine("Create your shopping list directory:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Create your shopping list file:");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory {newDirectory} exists at {rootDirectory}");
            }

            else if (newDirectory != "shoppingList" && fileName != "shoppingList.txt")
            {
                Console.WriteLine("Yu didn't choose shoppingList, have a great day!");
            }

            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }

        }
    }
}
