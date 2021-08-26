using System;
using System.Collections.Generic;
using System.Text;

namespace Name_Project
{
    class Person
    {
        //two properties, each of data type string. One called FirstName, the other LastName.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //writes the person's full name to the console in the format of: “Name: [full name]”
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
