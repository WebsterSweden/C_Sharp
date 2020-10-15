using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    public class BaseClass
    {
        string baseString = "baseString";
        static string baseStringStatic = "baseStringStatic";

        public string baseStringPublic = "baseStringPublic";
        public static string baseStringPublicStatic = "baseStringPublicStatic";

        private string baseStringPrivate = "baseStringPrivate";
        private static string baseStringPrivateStatic = "baseStringPrivateStatic";

        protected string baseStringProtected = "baseStringProtected";
        protected static string baseStringProtectedStatic = "baseStringProtectedStatic";

        internal string baseStringInternal = "baseStringInternal";
        internal static string baseStringInternalStatic = "baseStringInternalStatic";

        protected internal string baseStringProtectedInternal = "baseStringProtectedInternal";
        protected internal static string baseStringProtectedInternalStatic = "baseStringProtectedInternalStatic";

        private protected string baseStringPrivateProtected = "baseStringPrivateProtected";
        private protected static string baseStringPrivateProtectedStatic = "baseStringPrivateProtectedStatic";
    }
}
