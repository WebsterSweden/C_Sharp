using System;
using System.Collections.Generic;
using System.Text;

namespace Validation1
{
    class ValidationOne
    {
        public string ValidationOnePublicNonStatic()
        {
            bool validationOneStatus = false;
            string validationOneStringInput = "";
            while (validationOneStatus == false)
            {
                Console.Write("Enter a string One: ");
                validationOneStringInput = Console.ReadLine();
                if (validationOneStringInput != "One")
                {
                    Console.WriteLine("Entered string is not correct");
                    validationOneStatus = false;
                }
                else if (validationOneStringInput == "One")
                {
                    Console.WriteLine("Entered string is correct");
                    validationOneStatus = true;
                }
            }
            return validationOneStringInput;
        }

        public string ValidationTwoPublicNonStaticParameter(string parameterTwo)
        {
            string validationTwoStringInput = "";
            bool validationTwoStatus = false;
            while (validationTwoStatus == false)
            {
                Console.Write("Enter a string Two: ");
                validationTwoStringInput = Console.ReadLine();
                if (validationTwoStringInput != "Two")
                {
                    Console.WriteLine("Entered string is not correct");
                    validationTwoStatus = false;
                }
                else
                {
                    Console.WriteLine("Entered string is correct");
                    validationTwoStatus = true;
                }
            }
            return validationTwoStringInput;
        }
    }
}
