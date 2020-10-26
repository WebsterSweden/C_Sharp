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

            bool validationOneStatus = true;
            string validationOneStringInput = "";
            while (validationOneStatus == true)
            {
                Console.Write("Enter a string: ");
                validationOneStringInput = Console.ReadLine();
                if (validationOneStringInput != "One")
                {
                    Console.WriteLine("Entered string is not correct");
                    validationOneStatus = true;
                }
                else if (validationOneStringInput == "One")
                {
                    Console.WriteLine("Entered string is correct");
                    validationOneStatus = false;
                }
            }
            Console.WriteLine("After while statement");
            return validationOneStringInput;
        }
    }
}
