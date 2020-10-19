using System;

namespace ParseTryParse1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "ABC";
            string stringTwo = "123";
            string stringThree = "0.03";
            string stringFour = "";

            try
            {
                //int.Parse(stringOne);
                //Console.WriteLine(stringOne);

                //int.Parse(stringTwo);
                //Console.WriteLine(stringTwo);

                //int.Parse(stringThree);
                //Console.WriteLine(stringThree);

                //int.Parse(stringFour);
                //Console.WriteLine(stringFour);
            }
            catch (Exception exceptionMessage)
            {
                Console.WriteLine(exceptionMessage.Message);
            }

            try
            {
                //bool tryParseReturnValue = int.TryParse(stringOne, out int intOne);
                //if (tryParseReturnValue == true)
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}
                //Console.WriteLine(stringOne + " " + intOne);

                //bool tryParseReturnValue = int.TryParse(stringTwo, out int intTwo);
                //if (tryParseReturnValue == true)
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}
                //Console.WriteLine(stringTwo + " " + intTwo);

                //bool tryParseReturnValue = int.TryParse(stringThree, out int intThree);
                //if (tryParseReturnValue == true)
                //{
                //    Console.WriteLine("true");
                //}
                //else
                //{
                //    Console.WriteLine("false");
                //}
                //Console.WriteLine(stringThree + " " + intThree);

                bool tryParseReturnValue = int.TryParse(stringFour, out int intFour);
                if (tryParseReturnValue == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                Console.WriteLine(stringFour + " " + intFour);
            }
            catch (Exception exceptionMessage)
            {
                Console.WriteLine(exceptionMessage.Message);
            }
        }
    }
}
