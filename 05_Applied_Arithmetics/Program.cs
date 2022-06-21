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

            string cmnd;

            while((cmnd = Console.ReadLine()) != "end")
            {

            }
        }
    }
}
