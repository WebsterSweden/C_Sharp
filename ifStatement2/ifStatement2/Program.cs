using System;

namespace ifStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerOne = 3;
            int integerTwo = 6;
            int integerThree = 9;

            bool boolTrue = true;
            bool boolFalse = false;

            if (boolTrue) { Console.WriteLine("if statement 1 with condition true"); }
            if (boolTrue) { Console.WriteLine("if statement 2 with condition true"); }
            if (boolTrue) { Console.WriteLine("if statement 3 with condition true"); }

            Console.WriteLine();

            if (boolTrue) { Console.WriteLine("if statement 1 with condition true"); }
            else if (boolTrue) { Console.WriteLine("else if 1 statement with condition true"); }
            else if (boolTrue) { Console.WriteLine("else if 2 statement with condition true"); }
        }
    }
}
