using System;

namespace switchStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int switchOneInput = 0;

            Console.Write("Enter a number between 1 and 3: ");
            int switchOneInput = Convert.ToInt32(Console.ReadLine());

            string switchOneOutput;

            switch (switchOneInput)
            {
                case 1:
                    switchOneOutput = "One";
                    Console.WriteLine(switchOneOutput);
                    break;
                case 2:
                    switchOneOutput = "Two";
                    Console.WriteLine(switchOneOutput);
                    break;
                case 3:
                    switchOneOutput = "Three";
                    Console.WriteLine(switchOneOutput);
                    break;
                default:
                    switchOneOutput = "Unknown Input";
                    Console.WriteLine(switchOneOutput);
                    break;
            }
        }
    }
}
