using System;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClassObject = new BaseClass();
            Console.WriteLine(baseClassObject.baseStringPublic);
            Console.WriteLine(baseClassObject.baseStringInternal);
            Console.WriteLine(baseClassObject.baseStringProtectedInternal);

            Console.WriteLine(BaseClass.baseStringPublicStatic);
            Console.WriteLine(BaseClass.baseStringInternalStatic);
            Console.WriteLine(BaseClass.baseStringProtectedInternalStatic);

            Console.WriteLine("----------");

            DerivedClass derivedClassObject = new DerivedClass();
            Console.WriteLine(derivedClassObject.derivedStringPublic);
            Console.WriteLine(derivedClassObject.derivedStringInternal);
            Console.WriteLine(derivedClassObject.derivedStringProtectedInternal);
            Console.WriteLine(derivedClassObject.baseStringPublic);
            Console.WriteLine(derivedClassObject.baseStringInternal);
            Console.WriteLine(derivedClassObject.baseStringProtectedInternal);
        }
    }
}
