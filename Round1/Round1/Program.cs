using System;

namespace Round1
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleOne = 0.123456789;

            Console.WriteLine(doubleOne);

            Console.WriteLine(Math.Round(doubleOne));

            Console.WriteLine(Math.Round(doubleOne, 0));

            Console.WriteLine(Math.Round(doubleOne, 1));

            Console.WriteLine(Math.Round(doubleOne, 2));

            Console.WriteLine(Math.Round(doubleOne, 3));
        }
    }
}
