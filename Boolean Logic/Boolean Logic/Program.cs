using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main()
        {
            //Print out a line of text on the console.
            Console.WriteLine("What is your age (0 - 150)?");

            //Assign the user-entered value converted to a ushort to a variable.
            ushort age =  ushort.Parse(Console.ReadLine());

            //Print out a line of text on the console.
            Console.WriteLine("Have you ever had a DUI (true or false)?");

            //Assign the user-entered value converted to a boolean to a variable.
            bool dui = bool.Parse(Console.ReadLine());

            //Print out a line of text on the console.
            Console.WriteLine("How many speeding tickets do you have? (0 - 100)");

            //Assign the user-entered value converted to a ushort to a variable.
            ushort tickets = ushort.Parse(Console.ReadLine());

            //Print out a line of text on the console.
            Console.WriteLine("Qualified?");

            //Write a boolean value to the console representing whether or not
            //age is greater than 15, dui is false, and tickets is less than or equal to 3.
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.Read();
        }
    }
}
