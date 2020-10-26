using System;

namespace Validation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppercase and/or lowercase letters.
            // Ignore case.
            // Positive integers (0123456789).
            // Positive decimal numbers and only one decimal point (0123456789.).
            // Positive and negative integers.

            // Instantiate Non Static Object with no argument/parameter.
            ValidationOne validationOneObject = new ValidationOne();
            validationOneObject.validationOnePublicNonStatic();

            // Instantiate Non Static Object with argument/parameter.
            //string validationTwoReadLine = Console.ReadLine();
            ValidationOne validationTwoObject = new ValidationOne();
            //validationTwoObject.validationTwoPublicNonStaticParameter(validationTwoReadLine);
            Console.Write("Enter a string: ");
            string validationTwoReadLine = validationTwoObject.validationTwoPublicNonStaticParameter(Console.ReadLine());
        }
    }
}
