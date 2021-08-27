using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Assignment
{
    public class Employee
    {
        public Employee(int id, string first, string last)
        {
            Id = id;
            FirstName = first;
            LastName = last;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
