using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1
{
    class ParameterizedConstructor
    {
        // Parameterized Constructor.
        // Have at least one parameter. It can initialize each instance of the class to different values.

        public string parameterizedConstructorStringPublicNoValue;
        public int parameterizedConstructorIntPublicNoValue;

        public ParameterizedConstructor(string parameterString, int parameterInt)
        {
            parameterizedConstructorStringPublicNoValue = parameterString;
            parameterizedConstructorIntPublicNoValue = parameterInt;
        }
    }
}
