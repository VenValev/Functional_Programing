using System;
using System.Collections.Generic;

namespace _04_Find_Even_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string range = Console.ReadLine();
            int startRange = int.Parse(range.Split()[0]);
            int endRange = int.Parse(range.Split()[0]);
            string cmnd = Console.ReadLine();

            List<int> numbers = new List<int>();

            for(int i = startRange; i <= endRange; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = null;

            if(cmnd == "even")
            {
                predicate = numbers => numbers % 2 == 0;
            }
            else
            {
                predicate = numbers => numbers % 2 != 0;
            }

            Console.WriteLine(string.Join(' ', numbers.FindAll(predicate)));
        }
    }
}
