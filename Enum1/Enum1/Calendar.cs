using System;

namespace Enum1
{
    enum EnumThree
    {
        Alpha,
        Bravo,
        Gamma
    }

    class Calendar
    {
        // Enum created inside a class can not be accessible outside the class.
        public enum EnumFour
        {
            One,
            Two,
            Three
        }
    }
}
