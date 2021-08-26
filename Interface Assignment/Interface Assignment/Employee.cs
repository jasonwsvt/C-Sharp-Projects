using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment
{
    //Create another class called Employee and have it inherit from the Person class.
    //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
    class Employee : Person, IQuittable
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);
        }
        //Use polymorphism to create an object of type IQuittable.
        public void Quit()
        {
            Environment.Exit(0);
        }
    }
}
