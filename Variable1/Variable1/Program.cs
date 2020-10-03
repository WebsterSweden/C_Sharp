using System;

namespace Variable1
{
    class Program
    {
        string stringTwo = "stringTwo";

        public readonly string stringThreeReadonly = "stringThreeReadonly"; // Must be public.

        public string stringFourPublic = "stringFourPublic";

        public static string stringFiveStatic = "stringFiveStatic"; // Must be public.

        static void Main(string[] args)
        {
            string stringOne = "stringOne";
            Console.WriteLine(stringOne);
            stringOne = "stringOneNewValue";
            Console.WriteLine(stringOne);

            var stringTwoVariable = new Program();
            Console.WriteLine(stringTwoVariable.stringTwo);

            //object stringThreeReadonlyVariable = new Program(); // object do not work.
            var stringThreeReadonlyVariable = new Program();
            Console.WriteLine(stringThreeReadonlyVariable.stringThreeReadonly);

            var stringFourPublicVariable = new Program();
            stringFourPublicVariable.stringFourPublic = "stringFourPublicNewValue";
            Console.WriteLine(stringFourPublicVariable.stringFourPublic);

            var stringFiveStaticVariable = new Program();
            //Console.WriteLine(stringFiveStaticVariable.stringFiveStatic); // CS0176 Member cannot be accessed with an instance reference; qualify it with a type name instead.
            Console.WriteLine(stringFiveStatic);

        }
    }
}
