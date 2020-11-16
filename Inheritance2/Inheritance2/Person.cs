using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    public class Person
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public string GetDetails() => $"{FullName} of age {Age}";
    }
}
