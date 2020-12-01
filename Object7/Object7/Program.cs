using System;

namespace Object7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employment personOne = new Employment("FirstNameOne", "LastNameOne", 1970, "Office", 1990);

            Console.WriteLine($"{personOne.FirstName} {personOne.LastName} {personOne.BirthYear} {personOne.WorkTitle} {personOne.EmploymentYear} {personOne.YearsOfEmploymentMethod(personOne)}");

            //personOne.YearsOfEmploymentMethod(personOne);
        }
    }
}
