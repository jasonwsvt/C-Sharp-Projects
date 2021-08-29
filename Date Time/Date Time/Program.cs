using System;

namespace Date_Time
{
    class Program
    {
        static void Main()
        {
            //Print text including the current date and time to the console.
            Console.WriteLine("Current date and time: " + DateTime.Now.ToString());

            //Request an integer from the user.
            Console.Write("Please enter an integer: ");

            //Provide initial values to two variables
            int hours = 0;
            bool valid = false;

            //Attempt reading an integer input value from the user, and continue requesting one until it's provided.
            do
            {
                try
                {
                    hours = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch
                {
                    Console.Write("Please enter a valid string of numbers with no decimal: ");
                }
            }
            while (!valid);

            //Print text including the inputted number of hours, and a date/time string adjusted that amount of time.
            Console.WriteLine("Current date and time in {0} hours: {1}", hours, DateTime.Now.AddHours(hours).ToString());
        }
    }
}
