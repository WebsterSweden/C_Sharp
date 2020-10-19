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

                int.Parse(stringFour);
                Console.WriteLine(stringFour);
            }
            catch (Exception exceptionMessage)
            {
                Console.WriteLine(exceptionMessage.Message);
            };


        }
    }
}
