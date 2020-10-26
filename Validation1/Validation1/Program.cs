using System;

namespace Validation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppercase and/or lowercase letters.
            // Positive integers (0123456789).
            // Positive decimal numbers and only one decimal point (0123456789.).
            // Positive and negative integers.

            ValidationOne validationOneObject = new ValidationOne();

            //var validationOneObjectVariable = validationOneObject.validationOnePublicNonStatic(Console.ReadLine());
            //Console.WriteLine(validationOneObjectVariable);

            validationOneObject.validationOnePublicNonStatic();
        }
    }
}
