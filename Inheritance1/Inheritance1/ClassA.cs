using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class ClassA
    {
        public string classAString = "classAStringPublic";

        //public ClassA()
        public ClassA(string classAArgument)
        {
            classAString = classAArgument;
            //classAString = "ConstructorA";
        }
    }
}
