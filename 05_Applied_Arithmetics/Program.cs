using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Action<List<int>> print = list => Console.WriteLine(String.Join(" ", list));
            Func<List<int>, List<int>> op = null;
            string cmnd;

            while((cmnd = Console.ReadLine()) != "end")
            {
                if(cmnd == "add")
                {
                    op = list => list.Select(number => number += 1).ToList();
                    numbersList = op(numbersList);
                }
                else if(cmnd == "multiply")
                {
                    op = list => list.Select(number => number *= 2).ToList();
                    numbersList = op(numbersList);
                }
                else if (cmnd == "subtract")
                {
                    op = list => list.Select(number => number -= 1).ToList();
                    numbersList = op(numbersList);
                }
                else if (cmnd == "print")
                {
                    print(numbersList);
                }
                
            }
        }
    }
}
