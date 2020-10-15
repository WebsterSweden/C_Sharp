using System;
using System.Security.Cryptography.X509Certificates;

namespace AccessModifier1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access Modifier public.
            // Type or namespace definition, or end-of-file expected.
            //public string mainStringPublic = "mainStringPublic";
            string mainStringOne = "mainStringOne";
            Console.WriteLine(mainStringOne);

            // CS0106: The modifier public is not valid for this item.
            //public void mainMethodOne() { }
            string mainMethodOne()
            {
                string mainMethodOneString = "mainMethodOneString";
                return mainMethodOneString;
            }
            Console.WriteLine(mainMethodOne());

            Public publicObject = new Public();
            Console.WriteLine(publicObject.publicStringPublic);

            Console.WriteLine(Public.publicStringPublicStatic);

            // Access Modifier private.
            Private privateObject = new Private();
            Console.WriteLine(privateObject.PrivateString);
            Console.WriteLine(privateObject.PrivateStringPrivate);
            Console.WriteLine(privateObject.PrivateStringStatic);
            Console.WriteLine(privateObject.PrivateStringPrivateStatic);

            // Private Static is not accessible.
            //Private.

            // Access Modifier protected.
            // TODO.

            // Access Modifier internal.
            // TODO.

            // Access Modifier protected internal.
            // TODO.

            // Access Modifier private protected.
            // TODO.
        }
    }
}
