using System;
using System.Collections.Generic;
using System.Text;

namespace this1
{
    class Person
    {
        private string name;

        private int age;
        public string Name { get; set; }

        public int Age { get; set; }

        //public Person(string name, int age)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //}

        //public Person(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}

        //public Person(string name, int age)
        //{
        //    name = name;
        //    age = age;
        //}

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
