using System;

namespace Name_Project
{
    class Program
    {
        static void Main()
        {
            //instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”
            Employee sample = new Employee { FirstName = "Sample", LastName = "Student" };

            //Call the superclass method SayName() on the Employee object
            sample.SayName();
        }
    }
}
