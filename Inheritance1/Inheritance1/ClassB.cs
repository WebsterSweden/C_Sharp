using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class ClassB
    {
        public string classBString = "classBStringPublic";

        //public ClassB()
        public ClassB(string classBArgument)
        {
            classBString = classBArgument;
            //classBString = "ConstructorB";
        }
    }
}
