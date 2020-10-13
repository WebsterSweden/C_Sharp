using System;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try { }
            //catch { }

            //try
            //{
            //    // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //    Console.WriteLine("Divide by zero");
            //    Console.Write("Enter number 1: ");
            //    int one = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter number 0: ");
            //    int zero = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(one / zero);
            //}
            //catch
            //{
            //    Console.WriteLine("Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.");
            //}

            try
            {
                int[] arrayOne = { 1, 2, 3 };
                Console.WriteLine(arrayOne[3]);
            }
            catch (Exception exceptionMessageOne)
            {
                Console.WriteLine(exceptionMessageOne.Message);
            }

            try
            {
                int[] arrayTwo = { 1, 2, 3 };
                Console.WriteLine(arrayTwo[3]);
            }
            catch (Exception exceptionMessageTwo)
            {
                Console.WriteLine(exceptionMessageTwo.Message);
            }
            finally
            {
                Console.WriteLine("try catch finally");
            }

            // Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //int a = 1;
            //int b = 0;
            //Console.WriteLine(a / b);

            try
            {
                int x = 1;
                //int y = 0;
                Console.Write("Enter letter A: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x / y);
            }
            catch (DivideByZeroException DivideByZeroExceptionMessage)
            {
                Console.WriteLine(DivideByZeroExceptionMessage);
            }
            catch (FormatException FormatExceptionMessage)
            {
                Console.WriteLine(FormatExceptionMessage);
            }
            finally
            {
                Console.WriteLine("try DivideByZeroException FormatException finally");
            }

            //NumberCheck(50);
        }

        //static void NumberCheck(int numberInput)
        //{
        //    int numberIndex = 50;

        //    if (numberInput > numberIndex)
        //    {
        //        Console.WriteLine("Number {0} is higher than {1}", numberInput, numberIndex);
        //        //throw new ArithmeticException("ArithmeticException");
        //    }
        //    else if (numberInput < 50)
        //    {
        //        Console.WriteLine("Number {0} is lower than {1}", numberInput, numberIndex);
        //        //throw new ArithmeticException("ArithmeticException");
        //    }
        //    else if (numberInput == numberIndex)
        //    {
        //        Console.WriteLine("Number {0} is the same as {1}", numberInput, numberIndex);
        //        throw new ArithmeticException("ArithmeticException");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Input is out of range");
        //        //throw new ArithmeticException("ArithmeticException");
        //    }
        //}
    }
}
