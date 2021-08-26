using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee sample = new Employee { FirstName = "Sample", LastName = "Student "};

            //Call the SayName() method on the object.
            sample.SayName();
        }
    }
}
