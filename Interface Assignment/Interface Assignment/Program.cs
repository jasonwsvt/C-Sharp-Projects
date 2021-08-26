using System;

namespace Interface_Assignment
{
    class Program
    {
        static void Main()
        {
            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee sample = new Employee { FirstName = "Sample", LastName = "Student " };

            //Call the SayName() method on the object.
            sample.SayName();

            //Call the IQuittable.Quit method from the employee.
            sample.Quit();
        }
    }
}
