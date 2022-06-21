using System;
using System.Linq;

namespace _11_TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int treshold = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");
            Console.WriteLine(names.First(name => name.Select(symbol => (int)symbol).Sum() >= treshold));
        }
    }
}
