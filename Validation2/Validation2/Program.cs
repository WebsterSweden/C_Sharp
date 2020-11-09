using System;
using System.Linq;

namespace Validation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if string is null.
            string nullString = null;

            if (nullString == null)
            {
                Console.WriteLine($"nullString has a value of: {nullString}: ");
                //Console.WriteLine($"nullString.Length{nullString.Length}: ");
            }

            Console.WriteLine("   ".IsEmptyOrAllSpaces());
            Console.WriteLine("".IsEmptyOrAllSpaces());
            Console.WriteLine(" ".IsEmptyOrAllSpaces());
            Console.WriteLine("ABC   ".IsEmptyOrAllSpaces());
            Console.WriteLine("   DEF".IsEmptyOrAllSpaces());
            Console.WriteLine("ABC   DEF".IsEmptyOrAllSpaces());
        }
    }

    // Class non-generic, static, non-nested.
    // Every method static.
    // First parameter should us the this keyword.
    static class LinqHelper
    {
        public static bool IsEmptyOrAllSpaces(this string stringToCheck)
        {
            return null != stringToCheck && stringToCheck.All(c => c.Equals(' '));
        }
    }
}
