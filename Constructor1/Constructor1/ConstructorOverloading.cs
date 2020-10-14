using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1
{
    class ConstructorOverloading
    {
        // Constructor Overloading.
        // Overload the Constructor by creating another Constructor with the same method name but with different parameters.

        public string constructorOverloadingStringPublicNoValue;
        public int constructorOverloadingIntPublicNoValue;

        // Default Constructor (no parameters)
        public ConstructorOverloading()
        {
            constructorOverloadingStringPublicNoValue = "constructorOverloadingStringPublicDefaultValue";
            constructorOverloadingIntPublicNoValue = 3;
        }

        public ConstructorOverloading(string parameterString, int parameterInt)
        {
            constructorOverloadingStringPublicNoValue = parameterString;
            constructorOverloadingIntPublicNoValue = parameterInt;
        }
    }
}
