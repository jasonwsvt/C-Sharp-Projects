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

        //Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee one, Employee two)
        {
            return (one.FirstName == two.FirstName && one.LastName == two.LastName);
        }

        //Added below method as per Compiler Error CS0216
        public static bool operator !=(Employee one, Employee two)
        {
            return (one.FirstName != two.FirstName || one.LastName != two.LastName);
        }

        //Added both of the methods below as per Compiler Warning (level 3) CS0660
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        //Added below method as per Compiler Warning (level 3) CS0659 and CS0661
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
