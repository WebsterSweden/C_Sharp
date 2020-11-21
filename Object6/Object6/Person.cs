using System;
using System.Collections.Generic;
using System.Text;

namespace Object6
{
    class Person
    //public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public User user { get; set; }

        public void PersonMethodOne()
        {
            FirstName = "FirstNameMethodOne";
            LastName = "LastNameMethodOne";
            Address = "AddressMethodOne";

            Console.WriteLine($"{FirstName} {LastName} {Address}");
        }

        public void PersonMethodTwo(User userParameter)
        {
            user = userParameter;
            Console.WriteLine($"{user.UserName}");
        }
    }
}
