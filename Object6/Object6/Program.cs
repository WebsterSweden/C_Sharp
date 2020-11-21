using System;

namespace Object6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Address = "Address",
            };

            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Address}");

            User user = new User()
            {
                UserName = "UserName",
            };

            Console.WriteLine($"{user.UserName}");

            person.PersonMethodOne();

            user.UserMethodOne();

            person.PersonMethodTwo(user);
        }
    }
}
