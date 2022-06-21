using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Action<string> print = name => Console.WriteLine(name);

            names.ForEach(print);
            
        }
    }
}
