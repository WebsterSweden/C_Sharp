using System;
using System.Threading;

namespace doStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int doWhileIndexOne = 0;

            //do
            //{
            //    Console.WriteLine("doWhileIndexOne: " + doWhileIndexOne);
            //    doWhileIndexOne++;
            //}
            //while (doWhileIndexOne <= 6);

            //do
            //{
            //    while (!Console.KeyAvailable)
            //    {
            //        Console.WriteLine("Press the ESC to terminate the application");
            //        //Thread.Sleep(500);
            //        string input = Console.ReadLine();
            //        Console.WriteLine(input);
            //    }
            //}
            //while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            //do
            //{
            //    Console.WriteLine("do statement outer");
            //    Thread.Sleep(500);
            //}
            //while (true);

            //do
            //{
            //Console.WriteLine("do statement outer while not press escape key");
            //Thread.Sleep(500);
            //while (!Console.KeyAvailable)
            //{
            //Console.WriteLine("Console.KeyAvailable");
            //Console.ReadKey();
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //}
            //}
            //while (Console.ReadKey().Key == ConsoleKey.Escape);
            //while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            //while (Console.ReadKey(false).Key != ConsoleKey.Escape);

            Console.WriteLine("Press ESC to stop: ");

            while ((!Console.KeyAvailable) && Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                //Console.Write($"Press ESC to terminate the application: ");
                //string input = Console.ReadLine();
                //Console.WriteLine($"Entered input: {Console.ReadKey().Key}. The application continue to execute");
                Console.WriteLine("The Enter key is not pressed");
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }
    }
}
