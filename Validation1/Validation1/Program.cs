using System;

namespace Validation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Positive integers (0123456789).
            // Positive decimal numbers and only one decimal point (0123456789.).
            // Positive and negative integers.

            // String compare ignore case.
            ValidationThree validationStringCompare = new ValidationThree();
            validationStringCompare.ValidationStringCompare();

            // Instantiate a Non Static Object with no arguments/parameters.
            //ValidationOne validationOneObject = new ValidationOne();
            //validationOneObject.ValidationOnePublicNonStatic();

            // Instantiate a Non Static Object with arguments/parameters.
            //ValidationOne validationTwoObject = new ValidationOne();
            //validationTwoObject.ValidationTwoPublicNonStaticParameter(Console.ReadLine());
            //validationTwoObject.ValidationTwoPublicNonStaticParameter("ValidationTwoArgument");

            // Instantiate a Static Object with no arguments/parameters.
            //ValidationTwo.ValidationThreePublicStatic();

            // Instantiate a Static Object with arguments/parameters.
            //ValidationTwo.ValidationFourPublicStaticParameter(Console.ReadLine());
            //ValidationTwo.ValidationFourPublicStaticParameter("ValidationFourArgument");
        }
    }
}
