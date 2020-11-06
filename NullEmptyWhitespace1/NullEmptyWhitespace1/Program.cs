using System;
using System.Text.RegularExpressions;

namespace NullEmptyWhitespace1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nullEmptyWhitespace;

            nullEmptyWhitespace = null;

            if (String.IsNullOrWhiteSpace(nullEmptyWhitespace))
            //if (nullEmptyWhitespace == null)
            {
                Console.WriteLine("nullEmptyWhitespace is null");
            }
            else
            {
                Console.WriteLine("nullEmptyWhitespace is not null");
            }

            nullEmptyWhitespace = "";

            if (String.IsNullOrWhiteSpace(nullEmptyWhitespace))
            //if (nullEmptyWhitespace == "")
            {
                Console.WriteLine("nullEmptyWhitespace is empty");
            }
            else
            {
                Console.WriteLine("nullEmptyWhitespace is not empty");
            }

            nullEmptyWhitespace = " ";

            if (String.IsNullOrWhiteSpace(nullEmptyWhitespace))
            //if (nullEmptyWhitespace == " ")
            {
                Console.WriteLine("nullEmptyWhitespace have whitespace");
            }
            else
            {
                Console.WriteLine("nullEmptyWhitespace have not whitespace");
            }
        }
    }
}
