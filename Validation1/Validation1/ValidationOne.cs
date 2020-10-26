using System;
using System.Collections.Generic;
using System.Text;

namespace Validation1
{
    class ValidationOne
    {
        //public string validationOnePublicNonStatic(string parameterOne)
        public string validationOnePublicNonStatic()
        {
            //string returnString = "returnString";
            //return returnString;

            //if (parameterOne == "parameterOne")
            //{
            //    return "if";
            //}
            //else
            //{
            //    return "else";
            //}

            // Do not work. Check Console.ReadLine() only first time.
            //while (parameterOne != "parameterOne")
            //{
            //    Console.WriteLine($"The string {parameterOne} is not parameterOne");
            //    return parameterOne;
            //}
            //return parameterOne;

            // Do not work. Check Console.ReadLine() only first time.
            //Console.Write("Enter a string: ");
            //while (Console.ReadLine() != "parameterOne")
            //{
            //    Console.WriteLine($"The string {parameterOne} is not parameterOne");
            //    return parameterOne;
            //}
            //return parameterOne;

            bool validationOneStatus = false;
            string validationOneStringInput = "";
            while (validationOneStatus == false)
            {
                Console.Write("Enter a string: ");
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
            Console.WriteLine("After while statement");
            string returnString = "returnString";
            return returnString;
        }

        public string validationTwoPublicNonStaticParameter(string parameterTwo)
        {
            string validationTwoStringInput = "";
            bool validationTwoStatus = false;
            while (validationTwoStatus == false)
            {
                Console.Write("Enter a string: ");
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
