using System;
using System.Text.RegularExpressions;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexOne = new Regex(@"\d+");
            Match matchRegexOne = regexOne.Match("ABC123DEF");

            if (matchRegexOne.Success)
            {
                Console.WriteLine("matchRegexOne.Value: " + matchRegexOne.Value);
            }
        }
    }
}
