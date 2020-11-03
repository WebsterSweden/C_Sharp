using System;

namespace Object2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person personA = new Person("FirstNameA", "LastNameA", 30, "New York");
            //Person personB = new Person("FirstNameB", "LastNameB", 40, "Washington");
            //Person personC = new Person("FirstNameC", "LastNameC", 30, "San Francisco");
            //Person personD = new Person("FirstNameD", "LastNameD", 35, "New York");

            Person personA = new Person();
            personA.FirstName = "FirstNameA";
            Console.WriteLine(personA.FirstName);

            Company personACompany = new Company();
            personACompany.CompanyMethod(personA);
            Console.WriteLine(personACompany.PersonObjectA.FirstName);

            personA.FirstName = "FirstNameAChange";
            Console.WriteLine(personA.FirstName);
            Console.WriteLine(personACompany.PersonObjectA.FirstName);

            Education personAEducation = new Education();
            personAEducation.EducationMethod(personA);
            Console.WriteLine(personAEducation.PersonObjectA.FirstName);

            Console.WriteLine("----------");
        }
    }

    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        // Default Constructor.
        public Person() { }

        // Constructor with four parameters.
        public Person(string firstNameParameter, string lastNameparameter, int ageParameter, string cityParameter)
        {
            FirstName = firstNameParameter;
            LastName = lastNameparameter;
            Age = ageParameter;
            City = cityParameter;
        }
    }

    class Company
    {
        public Person PersonObjectA;

        //void CompanyMethod(Person personA, Person PersonB, Person personC, Person personD) { }
        public void CompanyMethod(Person personAParameter)
        {
            PersonObjectA = personAParameter;
        }
    }

    class Education
    {
        public Person PersonObjectA;

        public void EducationMethod(Person personAParameter)
        {
            PersonObjectA = personAParameter;
        }
    }
}
