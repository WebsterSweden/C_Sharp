using System;
using System.Collections.Generic;
using System.Text;

namespace Validation1
{
    class ValidationThree
    {
        public void ValidationStringCompare()
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            string stringOriginal = "String";
            string stringToCompare = "";
            bool validationStringStatus = false;
            //while (validationStringStatus == false)
            while (!stringComparer.Equals(stringOriginal, stringToCompare))
            {
                Console.Write("Enter string to compare: ");
                stringToCompare = Console.ReadLine();
                //if (stringToCompare != stringOriginal)
                if (!stringComparer.Equals(stringOriginal, stringToCompare))
                {
                    Console.WriteLine("The string is not the same as the original string");
                    validationStringStatus = false;
                }
                else
                {
                    Console.WriteLine("The string is the same as the original string");
                    validationStringStatus = true;
                }
            }
        }
    }
}
