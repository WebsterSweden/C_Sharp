using System;
using System.Text.RegularExpressions;

namespace Math1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number");
            //int intOne = Convert.ToInt32(Console.ReadLine());
            int intOne = 3;
            Console.WriteLine("Enter an integer number");
            //int intTwo = Convert.ToInt32(Console.ReadLine());
            int intTwo = 9;

            Console.WriteLine("Math.Max: " + Math.Max(intOne, intTwo));

            Console.WriteLine("Math.Min: " + Math.Min(intOne, intTwo));

            Console.WriteLine("Math.Sqrt: " + Math.Sqrt(intOne));

            Console.WriteLine("Math.Abs: " + Math.Abs(intOne));

            // 1.49 = 1
            // 1.5 = 2
            Console.WriteLine("Math.Round: " + Math.Round(1.49));

            Console.WriteLine("Math.Pow: " + Math.Pow(intOne, intTwo));

            Console.WriteLine(GetPow(2, 3));
        }

        //int baseNumber = 2;
        //int powerNumber = 3;
        static int GetPow(int baseNumber, int powerNumber)
        {
            int result = 1;

            for (int i = 0; i < powerNumber; i++)
            {
                result = baseNumber * result;
            }
            return result;
        }
    }
}
