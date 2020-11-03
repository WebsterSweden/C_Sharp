using System;

namespace Object3
{
    class ClassTwo
    {
        public ClassOne ClassOneObject;

        public void ClassTwoMethod(ClassOne classOneParameter)
        {
            ClassOneObject = classOneParameter;
            Console.WriteLine($"{ClassOneObject.StringOne} {ClassOneObject.StringTwo}");
        }
    }
}
