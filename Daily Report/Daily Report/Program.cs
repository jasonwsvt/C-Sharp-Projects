using System;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            //Writes text to the console.
            Console.WriteLine("The Tech Academy.");

            //Writes text to the console.
            Console.WriteLine("Student Daily Report.");

            //Writes text to the console.
            Console.WriteLine("What is your name?");

            //Receives user keyboard input and assigns it to a variable of type string. 
            string name = Console.ReadLine();

            //Writes text to the console.
            Console.WriteLine("What course are you on?");

            //Receives user keyboard input and assigns it to a variable of type string. 
            string course = Console.ReadLine();

            //Writes text to the console.
            Console.WriteLine("What page number?");

            //Receives user keyboard input, converts it to an unsigned integer, and assigns it to a variable of type string. 
            ushort page = Convert.ToUInt16(Console.ReadLine());

            //Writes text to the console.
            Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false\".");

            //Receives user keyboard input, converts it to a boolean, and assigns it to a variable of type string. 
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //Writes text to the console.
            Console.WriteLine("Were there any positive experiences you'd like to share?  Please give specifics.");

            //Receives user keyboard input and assigns it to a variable of type string. 
            string positiveExperiences = Console.ReadLine();

            //Writes text to the console.
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");

            //Receives user keyboard input and assigns it to a variable of type string. 
            string feedback = Console.ReadLine();

            //Writes text to the console.
            Console.WriteLine("How many hours did you study today?");

            //Receives user keyboard input, converts it to a byte, and assigns it to a variable of type string. 
            byte hours = Convert.ToByte(Console.ReadLine());

            //Writes text to the console.
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
        }
    }
}
