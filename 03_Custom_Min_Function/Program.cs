using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Func<List<int>, int> minFunc = numbers => numbers.Min();

            Console.WriteLine(minFunc(numbersList));
        }
    }
}
