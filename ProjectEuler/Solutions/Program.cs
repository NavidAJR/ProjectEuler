using System;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowAnswer(1, Problem1.Solution);

            ShowAnswer(2, Problem2.Solution);

            ShowAnswer(3, Problem3.Solution);

            ShowAnswer(4, Problem4.Solution);

            ShowAnswer(5, Problem5.Solution);

            ShowAnswer(6, Problem6.Solution);

            ShowAnswer(7, Problem7.Solution);

            ShowAnswer(8, Problem8.Solution);

            ShowAnswer(9, Problem9.Solution);

            ShowAnswer(10, Problem10.Solution);

            ShowAnswer(11, Problem11.Solution);
        }


        static void ShowAnswer(int problemNumber, Action solution)
        {
            Console.WriteLine($"---------Problem {problemNumber} Answer---------");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Answer is : ");

            Console.ForegroundColor = ConsoleColor.Green;
            var start = DateTime.Now;
            solution();
            var duration = DateTime.Now - start;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Duration: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(duration.Minutes + "m " + duration.Seconds + "s " + duration.Milliseconds.ToString("D5") + "ms");

            Console.ResetColor();

            Console.WriteLine();
        }
    }
}
