using System;
using System.Collections.Generic;
using System.Text;

namespace Object7
{
    class Employment : Person
    {
        public string WorkTitle { get; set; }
        public int EmploymentYear { get; set; }
        public int AgeWhenEmployed { get; set; }
        public Person Person { get; set; }

        public Employment(string firstNameParameter, string lastNameParameter, int birthYearParameter, string workTitleParameter, int employmentYearParameter)
        {
            FirstName = firstNameParameter;
            LastName = lastNameParameter;
            BirthYear = birthYearParameter;
            WorkTitle = workTitleParameter;
            EmploymentYear = employmentYearParameter;
        }

        public int YearsOfEmploymentMethod(Person personParameter)
        //public void YearsOfEmploymentMethod(Person personParameter)
        //public void YearsOfEmploymentMethod()
        {
            Person = personParameter;
            AgeWhenEmployed = EmploymentYear - Person.BirthYear;
            //Console.WriteLine(AgeWhenEmployed);
            return AgeWhenEmployed;
        }
    }
}
