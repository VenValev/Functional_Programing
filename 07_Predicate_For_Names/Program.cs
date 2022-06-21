using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //List<string> namesList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Predicate<string> exclude = name => name.Length <= n;

            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().FindAll(exclude).ForEach(Console.WriteLine);
        }
    }
}
