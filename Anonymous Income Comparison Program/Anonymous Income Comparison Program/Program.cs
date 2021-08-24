using System;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main()
        {
            //Prints a text string to the console.
            Console.WriteLine("Anonymous Income Comparison Program");

            //Prints a text string to the console.
            Console.WriteLine("Hourly rate for Person 1:");

            //Converts the user-entered string to a ushort and assigns it to a variable.
            ushort p1rate = ushort.Parse(Console.ReadLine());

            //Prints a text string to the console.
            Console.WriteLine("Hours worked for Person 1:");

            //Converts the user-entered string to a ushort and assigns it to a variable.
            ushort p1hours = ushort.Parse(Console.ReadLine());

            //Prints a text string to the console.
            Console.WriteLine("Hourly rate for Person 2:");

            //Converts the user-entered string to a ushort and assigns it to a variable.
            ushort p2rate = ushort.Parse(Console.ReadLine());

            //Prints a text string to the console.
            Console.WriteLine("Hours worked for Person 2:");

            //Converts the user-entered string to a ushort and assigns it to a variable.
            ushort p2hours = ushort.Parse(Console.ReadLine());

            //Assigns the product of the two variables to the integer variable.
            //The type change can be implicit because the variable being assigned is an equal or higher bit count.
            int p1salary = p1rate * p1hours * 52;

            //Assigns the product of the two variables to the integer variable.
            //The type change can be explicit, however.
            int p2salary = (int)p2rate * (int)p2hours * (byte)52;

            //Prints a text string consisting of a string concatenated to a variable to the console.
            Console.WriteLine("Annual salary of Person 1: " + (p1salary));

            //Prints a text string consisting of a string concatenated to a variable to the console.
            Console.WriteLine("Annual salary of Person 2: " + (p2salary));

            //Prints a text string to the console.
            Console.WriteLine("Does Person 1 make more money than Person2? ");

            //Prints the boolean result of the comparison evaluation of two variables.
            Console.WriteLine(p1salary > p2salary);
            Console.Read();
        }
    }
}
