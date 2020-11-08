using System;

namespace Color1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Console.ForegroundColor: {Console.ForegroundColor}");
            Console.WriteLine($"Console.BackgroundColor: {Console.BackgroundColor}");

            //Console.Clear();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Console.WriteLine($"Console.ForegroundColor: {Console.ForegroundColor}");
            Console.WriteLine($"Console.BackgroundColor: {Console.BackgroundColor}");
        }
    }
}
