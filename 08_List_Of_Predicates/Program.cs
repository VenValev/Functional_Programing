using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> deviders = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                numbers.Add(i);
            }
        }
    }
}
