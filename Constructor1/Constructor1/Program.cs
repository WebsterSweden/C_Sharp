using System;

namespace Constructor1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOne classOneObject = new ClassOne();
            Console.WriteLine("classOneObject.classOneStringPublic" + classOneObject.classOneStringPublic);

            Console.WriteLine("ClassOne.classOneStringPublicStatic" + ClassOne.classOneStringPublicStatic);

            // Call the ClassTwo Constructor.
            ClassTwo classTwoConstructor = new ClassTwo();
            Console.WriteLine("classTwoConstructor: " + classTwoConstructor);
            Console.WriteLine("classTwoConstructor.classTwoString: " + classTwoConstructor.classTwoStringPublic);
            Console.WriteLine("classTwoConstructor.classTwoIntPublic: " + classTwoConstructor.classTwoIntPublic);

            Console.WriteLine("----------");

            Console.WriteLine("classTwoConstructor.classTwoStringPublicNoValue: " + classTwoConstructor.classTwoStringPublicNoValue);
            Console.WriteLine("classTwoConstructor.classTwoIntPublicNoValue: " + classTwoConstructor.classTwoIntPublicNoValue);

            Console.WriteLine("----------");

            if (classTwoConstructor.classTwoStringPublicNoValue == null)
            {
                Console.WriteLine("classTwoConstructor.classTwoStringPublicNoValue: null");
            }
            else
            {
                Console.WriteLine("classTwoConstructor.classTwoStringPublicNoValue: " + classTwoConstructor.classTwoStringPublicNoValue);
            }

            Console.WriteLine("----------");

            // Default Constructor.
            DefaultConstructor defaultConstructorObject = new DefaultConstructor();
            if (defaultConstructorObject.defaultConstructorStringPublicNoValue == null)
            {
                Console.WriteLine("defaultConstructorObject.defaultConstructorStringPublicNoValue: null" + defaultConstructorObject.defaultConstructorStringPublicNoValue);
            }
            else
            {
                Console.WriteLine("defaultConstructorObject.defaultConstructorStringPublicNoValue: " + defaultConstructorObject.defaultConstructorStringPublicNoValue);
            }
            Console.WriteLine("defaultConstructorObject.defaultConstructorIntPublicNoValue: " + defaultConstructorObject.defaultConstructorIntPublicNoValue);

            Console.WriteLine("----------");

            ParameterizedConstructor parameterizedConstructorObject = new ParameterizedConstructor("parameterizedConstructorStringArgument", 3);
            Console.WriteLine("parameterizedConstructorObject.parameterizedConstructorStringPublicNoValue: " + parameterizedConstructorObject.parameterizedConstructorStringPublicNoValue);
            Console.WriteLine("parameterizedConstructorObject.parameterizedConstructorIntPublicNoValue: " + parameterizedConstructorObject.parameterizedConstructorIntPublicNoValue);

            Console.WriteLine("----------");

            // Constructor Overloading.

            // Default Constructor.
            ConstructorOverloading constructorOverloadingDefault = new ConstructorOverloading();
            Console.WriteLine("constructorOverloadingDefault.constructorOverloadingStringPublicNoValue: " + constructorOverloadingDefault.constructorOverloadingStringPublicNoValue);
            Console.WriteLine("constructorOverloadingDefault.constructorOverloadingIntPublicNoValue: " + constructorOverloadingDefault.constructorOverloadingIntPublicNoValue);

            // Parameterized Constructor.
            ConstructorOverloading constructorOverloadingParameterized = new ConstructorOverloading("constructorOverloadingStringPublicParameterizedValue", 6);
            Console.WriteLine("constructorOverloadingParameterized.constructorOverloadingStringPublicNoValue: " + constructorOverloadingParameterized.constructorOverloadingStringPublicNoValue);
            Console.WriteLine("constructorOverloadingParameterized.constructorOverloadingIntPublicNoValue: " + constructorOverloadingParameterized.constructorOverloadingIntPublicNoValue);

            Console.WriteLine("----------");

            // TODO: Constructor Chaining.

            // TODO: Private Constructor.

            // TODO: Static Constructor.
        }
    }
}
