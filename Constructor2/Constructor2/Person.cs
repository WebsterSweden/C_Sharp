using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor2
{
    class Person
    {
        // Private field with and without assignment.
        private string firstName = "FieldFirst";
        //private string firstName;
        private string lastName = "FieldLast";
        private int age;

        // Get Set Property.
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person() { }

        public Person(string firstNameParameter, string lastNameParameter, int ageParameter)
        {
            firstName = firstNameParameter;
            lastName = lastNameParameter;
            age = ageParameter;
        }

    }
}
