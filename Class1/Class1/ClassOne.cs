using System;
using System.Collections.Generic;
using System.Text;

namespace Class1
{
    public class ClassOne
    {
        //var varVariable = "varVariable"; // CS0825 The contextual keyword 'var' may only appear within a local variable declaration or in script mode.

        public string classOneString = "classOneString";

        // TODO: When to use object?
        object classTwoObject = new ClassTwo(); // CS0825 The contextual keyword 'var' may only appear within a local variable declaration or in script mode.

        public static string classOneStaticString = "classOneStaticString";

        public string ClassOneMethodOne(string classOneMethodOneParameter)
        {
            return classOneMethodOneParameter;
        }

        // Instantiate one class from another class using a method.
        // Instatiate ClassTwo from ClassOne.
        public string ClassOneMethodTwoInstantiateClassTwo()
        //string classOneMethodTwoInstantiateClassTwoParameter
        {
            var classOneMethodTwoInstantiateClassTwoVariable = new ClassTwo();
            return classOneMethodTwoInstantiateClassTwoVariable.ClassTwoMethodOne("ClassOneMethodTwoInstantiateClassTwo");
            //return classOneMethodTwoInstantiateClassTwoParameter;
        }

    }
}
