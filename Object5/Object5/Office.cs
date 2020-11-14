using System;
using System.Collections.Generic;
using System.Text;

namespace Object5
{
    class Office
    {
        public Person Employee { get; set; }

        public Person Boss { get; set; }

        public Office(Person employeeParameter, Person bossParameter)
        {
            Employee = employeeParameter;
            Boss = bossParameter;
        }

        //public void PrintWorkers()
        //{
        //    Console.WriteLine($"{Employee.Name}, {Employee.Age} years old from {Employee.City}");
        //    Console.WriteLine($"{Boss.Name}, {Boss.Age} years old from {Boss.City}");
        //}

        public void PrintWorkers(Person employeeParameter, Person bossParameter)
        {
            Console.WriteLine($"{employeeParameter.Name}, {employeeParameter.Age} years old from {employeeParameter.City}");
            Console.WriteLine($"{bossParameter.Name}, {bossParameter.Age} years old from {bossParameter.City}");
        }
    }
}
