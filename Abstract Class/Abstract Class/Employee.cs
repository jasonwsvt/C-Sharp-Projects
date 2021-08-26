using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    //Create another class called Employee and have it inherit from the Person class.
    class Employee : Person
    {
        //Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("Employee: " + FirstName + " " + LastName);
        }
    }
}
