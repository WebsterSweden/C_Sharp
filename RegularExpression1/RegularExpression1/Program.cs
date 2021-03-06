using System;
using System.Text.RegularExpressions;

namespace RegularExpression1
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexOne = new Regex(@"\d+");
            Match matchRegexOne = regexOne.Match("ABC123DEF456");

            if (matchRegexOne.Success)
            {
                Console.WriteLine("matchRegexOne.Value: " + matchRegexOne.Value);
            }

            string regexTwoInput = "ABC123DEF456";

            Regex regexTwo = new Regex(@"[0-9]+");
            Match matchRegexTwo = regexTwo.Match(regexTwoInput);
            Console.WriteLine(matchRegexTwo);

            var regexECMA = new Regex(@"\d+", RegexOptions.ECMAScript);
            Console.WriteLine(regexECMA);
            Match matchRegexECMA = regexECMA.Match("abc123ABC456");
            Console.WriteLine(matchRegexECMA);

            Console.WriteLine("----------");

            Console.Write("Only accept a-z, A-Z, 0-9: ");

            while (!Regex.IsMatch(Console.ReadLine(), "^[a-zA-Z0-9]*$"))
            {
                Console.Write("Entered characters have to be a-z, A-Z, 0-9: ");
            }
            Console.WriteLine("Accepted character");
        }
    }
}
