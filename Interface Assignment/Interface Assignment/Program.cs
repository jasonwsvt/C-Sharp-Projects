using System;

namespace Interface_Assignment
{
    class Program
    {
        static void Main()
        {
            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee sample = new Employee { FirstName = "Sample", LastName = "Student", Id = 1 };
            Employee sample2 = new Employee { FirstName = "Sample", LastName = "Student", Id = 2 };

            //Call the SayName() method on the object.
            sample.SayName();

            Console.WriteLine("Employees are the same? " + (sample == sample2));

            //Call the IQuittable.Quit method from the employee.
            sample.Quit();
        }
    }
}
