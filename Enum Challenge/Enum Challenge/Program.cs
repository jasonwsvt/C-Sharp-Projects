using System;

namespace Enum_Challenge
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter the day of the week: ");
            Enum day;
            bool valid = false;

            //Loop until the day is valid.
            do
            {
                //Wrap the above statement in a try/catch block.
                try
                {
                    //Prompt the user to enter the current day of the week.
                    //Assign the value to a variable of that enum data type you just created.
                    day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
                    valid = true;
                }
                catch
                {
                    //Have it print "Please enter an actual day of the week.” to the console if an error occurs.
                    Console.Write("Please enter an actual day of the week: ");
                }
            }
            while (!valid);
        }

        //Create an enum for the days of the week.
        public enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    }
}
