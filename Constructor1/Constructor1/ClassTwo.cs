using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor1
{
    class ClassTwo
    {
        public string classTwoStringPublic = "classTwoStringPublic";
        public string classTwoStringPublicNoValue;
        public int classTwoIntPublic = 3;
        public int classTwoIntPublicNoValue;

        public ClassTwo()
        {
            classTwoStringPublic = "classTwoStringConstructorValue";
            classTwoIntPublic = 6;
        }
    }
}
