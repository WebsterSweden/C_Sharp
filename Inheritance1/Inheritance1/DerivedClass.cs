using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class DerivedClass : BaseClass
    {
        BaseClass baseClassObject = new BaseClass();
        //baseClassObject.

        //BaseClass.

        string derivedString = "derivedString";
        static string derivedStringStatic = "derivedStringStatic";

        public string derivedStringPublic = "derivedStringPublic";
        public static string derivedStringPublicStatic = "derivedStringPublicStatic";

        private string derivedStringPrivate = "derivedStringPrivate";
        private static string derivedStringPrivateStatic = "derivedStringPrivateStatic";

        protected string derivedStringProtected = "derivedStringProtected";
        protected static string derivedStringProtectedStatic = "derivedStringProtectedStatic";

        internal string derivedStringInternal = "derivedStringInternal";
        internal static string derivedStringInternalStatic = "derivedStringInternalStatic";

        protected internal string derivedStringProtectedInternal = "derivedStringProtectedInternal";
        protected internal static string derivedStringProtectedInternalStatic = "derivedStringProtectedInternalStatic";

        private protected string derivedStringPrivateProtected = "derivedStringPrivateProtected";
        private protected static string derivedStringPrivateProtectedStatic = "derivedStringPrivateProtectedStatic";
    }
}
