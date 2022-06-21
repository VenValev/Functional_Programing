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
            int dev = int.Parse(Console.ReadLine());

            Action<List<int>> reverse = i =>
            {
                for (int j = 0; j < i.Count / 2; j++)
                {
                    int temp = i[j];
                    i[j] = i[i.Count - 1 - j];
                    i[i.Count - 1 - j] = temp;
                }
            };

            Predicate<int> exclude = number => number % dev != 0;

            reverse(numbersList);

            Console.WriteLine(string.Join(" ", numbersList.FindAll(exclude))); 


        }
    }
}
