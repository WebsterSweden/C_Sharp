using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FullName = "PersonName", Age = 24 };
            Console.WriteLine(person.GetDetails());

            Professor professor = new Professor() { FullName = "ProfessorName", Subject = "Subject", Age = 48 };
            Console.WriteLine(professor.GetDetails());

            Student student = new Student() { FullName = "StudentName", Age = 16, Grade = 12 };
            Console.WriteLine(student.GetDetails());
        }
    }
}
