using System;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Problem 1 Answer---------");
            Console.ForegroundColor = ConsoleColor.Green;
            Problem1.Solution();
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("---------Problem 2 Answer---------");
            Console.ForegroundColor = ConsoleColor.Green;
            Problem2.Solution();
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("---------Problem 3 Answer---------");
            Console.ForegroundColor = ConsoleColor.Green;
            Problem3.Solution();
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
