using System;
using System.Threading;

namespace whileStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int whileIndexOne = 0;

            //while (whileIndexOne <= 6)
            //{
            //    Console.WriteLine("whileIndexOne: " + whileIndexOne);
            //    Thread.Sleep(500);
            //    whileIndexOne++;
            //}

            string whileStringTwo = "whileStringTwoBeforeWhileStatement";
            //Console.WriteLine("whileStringTwo: " + whileStringTwo);
            int whileIndexTwo = 0;
            Console.WriteLine("whileIndexTwo before while statement: " + whileIndexTwo);
            while (whileIndexTwo < 3)
            {
                whileStringTwo = "whileStringTwoInsideWhileStatement";
                //Console.WriteLine("whileStringTwo: " + whileStringTwo);
                Console.WriteLine("whileIndexTwo inside while statement: " + whileIndexTwo);
                Thread.Sleep(1000);
                whileIndexTwo++;
            }
            whileStringTwo = "whileStringTwoAfterWhileStatement";
            //Console.WriteLine("whileStringTwo: " + whileStringTwo);
            Console.WriteLine("whileIndexTwo after while statement: " + whileIndexTwo);

            Console.WriteLine("----------");

            Console.Write("Enter a string: ");
            bool whileBoolThree = true;
            while (whileBoolThree == true)
            {
                string whileStringThree = Console.ReadLine();
                if (whileStringThree == "whileStringThree")
                {
                    Console.Write("whileStringThree true: " + whileStringThree);
                    Console.WriteLine($"The string {whileStringThree} is correct!");
                    whileBoolThree = false;
                }
                else if (whileStringThree == "Hello")
                {
                    Console.Write("whileStringThree true: " + whileStringThree);
                    Console.WriteLine($"The string {whileStringThree} is correct!");
                    whileBoolThree = false;
                }
                else
                {
                    Console.WriteLine("whileStringThree else: " + whileStringThree);
                    Console.Write($"The string {whileStringThree} is not correct. Enter a new string: ");
                    whileBoolThree = true;
                }
            }
            Console.WriteLine("After whileThree");
        }
    }
}
