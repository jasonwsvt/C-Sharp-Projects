using System;

namespace Parameters
{
    //Create an abstract class called Person with two properties: string firstName and string lastName.
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Give it the method SayName().
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
