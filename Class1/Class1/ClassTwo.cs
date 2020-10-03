using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    class ClassTwo
    {
        public string classTwoString = "classTwoString";

        public static string classTwoStaticString = "classTwoStaticString";

        public string ClassTwoMethodOne(string classTwoMethodOneParameter)
        {
            return classTwoMethodOneParameter;
        }

        public string ClassTwoMethodTwoInstantiateClassOne()
        {
            var classTwoMethodInstatiateClassOneVariable = new ClassOne();
            return classTwoMethodInstatiateClassOneVariable.ClassOneMethodOne("ClassTwoMethodTwoInstantiateClassOne");
        }
    }
}
