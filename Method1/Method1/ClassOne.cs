using System;
using System.Collections.Generic;
using System.Text;

namespace Method1
{
    public class ClassOne
    {
        public static string classOneString = "classOneString";

        public static string ClassOneMethodOne()
        {
            // CS1520 Method must have a return type.
            //Console.WriteLine("ClassOneMethodOne2");

            string classOneMethodOneReturn = "classOneMethodOneReturn";
            return classOneMethodOneReturn;

            // CS0126 An object of a type convertible to 'string' is required.
            //return;
        }

        public static string ClassOneMethodStatic(string classOneMethodStaticParameter)
        {
            return classOneMethodStaticParameter;
        }

        public static string stringStaticVariable = "stringStaticVariable";

        public string ClassOneMethodNonStatic(string classOneMethodNonStaticParameter)
        {
            return classOneMethodNonStaticParameter;
        }

        public string stringNonStaticVariable = "stringNonStaticVariable";

        //ClassOne.

        //ClassOne.ClassOneMethodStatic("ClassOneMethodStaticArgument");

        //var classOneObject = new ClassOne();
        //classOneObject.
    }
}
