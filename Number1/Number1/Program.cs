using System;
using System.Linq;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] numberArray = { -3.0, -1.5, 0.0, 1.5, 3.0 };
            double[] numberArray = { 0.0, 1.5, 3.0, 6.0, 12.0 };

            Console.WriteLine(numberArray.Min());
            Console.WriteLine(numberArray.Max());

            Console.WriteLine(Double.MinValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(Double.MaxValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(Math.Min(3, 6));
            Console.WriteLine(Math.Max(3, 6));

            Console.WriteLine("----------");

            double result = 0.0;

            foreach (var number in numberArray)
            {
                result += number;
            }

            Console.WriteLine(result);

            double averageNumber = result / numberArray.Length;

            Console.WriteLine(averageNumber);
        }
    }
}
