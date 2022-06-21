using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

        }
    }
}
