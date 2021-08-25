using System;

namespace Calling_Methods
{
    class Program
    {
        static void Main()
        {
            //Print text to the console.
            Console.Write("What number would you like to do the math operations on? ");

            //Set an initial value for num.
            int num = 0;

            //Used to confirm a successful assignment in the try block.
            bool valid = false;

            //Start a loop
            do {
                //Start a try catch block
                try
                {
                    //Take user-entered data, conver it to an integer, and assign it to num.
                    num = int.Parse(Console.ReadLine());

                    //If the previous statement succeeded
                    valid = true;
                }
                //If the assignment station was unsuccessful
                catch (FormatException)
                {
                    //Print text to the console
                    Console.Write("Please enter a valid integer: ");
                }
            }
            //Keep repeating the loop until there's a successful assignment to num
            while (valid == false);

            //Create a new instance of the Methods class.
            Methods methods = new Methods();

            //Invoke the three methods with the user-entered integer.
            Console.WriteLine("Result of Methods.PureFunc(" + num + "): " + methods.PureFunc(num));
            Console.WriteLine("Result of Methods.TimesThree(" + num + "): " + methods.TimesThree(num));
            Console.WriteLine("Result of Methods.TimesFive(" + num + "): " + methods.TimesFive(num));
        }
    }
}
