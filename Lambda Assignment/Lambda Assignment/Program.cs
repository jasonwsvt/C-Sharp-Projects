using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main()
        {
            //Create a list of at least 10 employees.
            //Each employee should have a first and last name, as well as an Id.
            //At least two employees should have the first name “Joe”.
            List<Employee> employees = new List<Employee>
            {
                new Employee(0, "Joe", "Smith"),
                new Employee(1, "Joe", "Williams"),
                new Employee(2, "Joseph", "Jones"),
                new Employee(3, "Josephine", "Levesque"),
                new Employee(4, "Joey", "Arbuckle"),
                new Employee(5, "Joachim", "Moran"),
                new Employee(6, "Jody", "Biden"),
                new Employee(7, "Joel", "Brumfeld"),
                new Employee(8, "Jory", "Foster"),
                new Employee(9, "Jon", "Gregory")
            };

            List<Employee> joes = new List<Employee>();
            //Using a foreach loop, create a new list of all employees with the first name “Joe”.
            foreach (Employee e in employees)
            {
                if (e.FirstName == "Joe")
                {
                    joes.Add(e);
                }
            }

            List<Employee> joes2 = new List<Employee>();
            //Perform the same action again, but this time with a lambda expression.
            joes2 = employees.FindAll(e => e.FirstName == "Joe");

            List<Employee> idsgt5 = new List<Employee>();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            joes2 = employees.FindAll(e => e.Id > 5);
        }
    }
}
