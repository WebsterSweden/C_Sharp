using System;
using System.Collections.Generic;
using System.Text;

namespace Validation1
{
    class ValidationTwo
    {
        public static string ValidationThreePublicStatic()
        {
            string validationThreeStringInput = "";
            bool validationThreeStatus = false;
            while (validationThreeStatus == false)
            {
                Console.Write("Enter a string Three: ");
                validationThreeStringInput = Console.ReadLine();
                if (validationThreeStringInput != "Three")
                {
                    Console.WriteLine("Entered string is not correct");
                    validationThreeStatus = false;
                }
                else
                {
                    Console.WriteLine("Entered string is correct");
                    validationThreeStatus = true;
                }
            }
            return validationThreeStringInput;
        }

        public static string ValidationFourPublicStaticParameter(string parameterFour)
        {
            string validationFourStringInput = "";
            bool validationFourStatus = false;
            while (validationFourStatus == false)
            {
                Console.Write("Enter a string Four: ");
                validationFourStringInput = Console.ReadLine();
                if (validationFourStringInput != "Four")
                {
                    Console.WriteLine("Entered string is not correct");
                    validationFourStatus = false;
                }
                else
                {
                    Console.WriteLine("Entered string is correct");
                    validationFourStatus = true;
                }
            }
            return validationFourStringInput;
        }
    }
}
