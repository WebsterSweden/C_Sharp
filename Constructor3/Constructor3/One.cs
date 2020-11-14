using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor3
{
    class One
    {
        public string stringOne { get; set; }

        public string stringTwo { get; set; }

        public int intOne { get; set; }

        public int intTwo { get; set; }

        public One() { }

        public One(string stringOneParameter)
        {
            Console.WriteLine(stringOneParameter);
        }

        //public One(string stringTwoParameter)
        //{
        //    Console.WriteLine(stringTwoParameter);
        //}

        public One(string stringOneParameter, string stringTwoParameter)
        {
            Console.WriteLine(stringOneParameter + stringTwoParameter);
        }

        public One(int intOneParameter)
        {
            Console.WriteLine(intOneParameter);
        }

        public One(int intOneParameter, int intTwoParameter)
        {
            Console.WriteLine(intOneParameter + intTwoParameter);
        }

        public One(string stringOneParameter, int intOneParameter)
        {
            Console.WriteLine(stringOneParameter + intOneParameter);
        }

        public One(int intTwoParameter, string stringTwoParameter)
        {
            Console.WriteLine(intTwoParameter + stringTwoParameter);
        }
    }
}
