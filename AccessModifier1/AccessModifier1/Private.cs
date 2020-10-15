using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier1
{
    class Private
    {
        //private string privateGetSet;

        string privateString = "privateString";
        private string privateStringPrivate = "privateStringPrivat";
        static string privateStringStatic = "privateStringStatic";
        private static string privateStringPrivateStatic = "privateStringPrivateStatic";

        // Private Constructor.
        public Private()
        {
            privateString = "privateStringPrivateStaticConstructor";
            privateStringPrivate = "privateStringPrivatConstructor";
            privateStringStatic = "privateStringStaticConstructor";
            privateStringPrivateStatic = "privateStringPrivateStaticConstructor";
        }

        // Private Get Set Properties.
        // Property works from both field value and Constructor value.
        public string PrivateString
        {
            get { return privateString; }
            set { privateString = value; }
        }

        public string PrivateStringPrivate
        {
            get { return privateStringPrivate; }
            set { privateStringPrivate = value; }
        }

        public string PrivateStringStatic
        {
            get { return privateStringStatic; }
            set { privateStringStatic = value; }
        }

        public string PrivateStringPrivateStatic
        {
            get { return privateStringPrivateStatic; }
            set { privateStringPrivateStatic = value; }
        }
    }
}
