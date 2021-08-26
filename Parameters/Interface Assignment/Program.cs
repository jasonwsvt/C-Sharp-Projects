using System;

namespace Parameters
{
    class Program
    {
        static void Main()
        {
            //Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            //Instantiate an Employee object with type “string” as its generic parameter.
            Employee<string> sample = new Employee<string> { FirstName = "Sample", LastName = "Student", Id = 1 };

            //Assign a list of strings as the property value of Things.
            //sample.Things.AddRange(new string[] { "One", "Two", "Three", "Four" });
            sample.Things.Add("One");
            sample.Things.Add("Two");
            sample.Things.Add("Three");

            //Instantiate an Employee object with type “int” as its generic parameter.
            Employee<int> sample2 = new Employee<int> { FirstName = "Sample", LastName = "Student", Id = 2 };

            //Assign a list of integers as the property value of Things.
            //sample2.Things.AddRange(new int[] { 1, 2, 3, 4 });
            sample2.Things.Add(1);
            sample2.Things.Add(2);
            sample2.Things.Add(3);

            //Call the SayName() method on the object.
            sample.SayName();

            //Create a loop that prints all of the Things to the Console.
            sample.PrintThings();

            //Call the SayName() method on the object.
            sample2.SayName();

            //Create a loop that prints all of the Things to the Console.
            sample2.PrintThings();

            //Call the IQuittable.Quit method from the employee.
            sample.Quit();
        }
    }
}
