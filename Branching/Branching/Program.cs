using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            //Print a line of text to the console.
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            //Print a line of text to the console.
            Console.WriteLine("Please enter the package weight:");

            //Read text from the console, convert it to a float, and assign it to a variable.
            float weight = float.Parse(Console.ReadLine());

            //Conditional statement for whether or not the weight variable contains a value greater than 50.
            if (weight > 50)
            {
                //Print a line of text to the console.
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");

                //Quit the app.
                return;
            }
            //Print a line of text to the console.
            Console.WriteLine("Please enter the package width:");

            //Conditional statement for whether or not the width variable contains a value greater than 50.
            float width = float.Parse(Console.ReadLine());
            if (width > 50)
            {
                //Print a line of text to the console.
                Console.WriteLine("Package too wide to be shipped via Package Express.  Have a good day.");

                //Quit the app.
                return;
            }
            //Print a line of text to the console.
            Console.WriteLine("Please enter the package height:");

            //Conditional statement for whether or not the sum of the width and height variables is greater than 50.
            float height = float.Parse(Console.ReadLine());
            if (width + height > 50)
            {
                //Print a line of text to the console.
                Console.WriteLine("Package too tall to be shipped via Package Express.  Have a good day.");

                //Quit the app.
                return;
            }
            //Print a line of text to the console.
            Console.WriteLine("Please enter the package length:");

            //Conditional statement for whether or not the sum of the width, height, and length variables is greater than 50.
            float length = float.Parse(Console.ReadLine());
            if (width + height + length > 50)
            {
                //Print a line of text to the console.
                Console.WriteLine("Package too long to be shipped via Package Express.  Have a good day.");

                //Quit the app.
                return;
            }

            //Print a line of text to the console.
            Console.WriteLine("Your estimated total for shipping this package is: " + string.Format("{0:C}", height * width * length * weight / 100));

            //Print a line of text to the console.
            Console.WriteLine("Thank you!");
        }
    }
}
