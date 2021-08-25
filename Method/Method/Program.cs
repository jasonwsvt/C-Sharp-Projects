using System;

namespace Method
{
    class Program
    {
        static void Main()
        {
            //Create a new Methods instance
            Methods n = new Methods();
            
            //Print text to the console
            Console.Write("Please enter a number: ");

            //Read user-entered text, convert it to an integer, assign it to a variable
            int first = int.Parse(Console.ReadLine());

            //Print text to the console
            Console.Write("Please enter a second number if you like: ");

            //If an integer is entered, call the function with both variables,
            try
            {
                //Read user-entered text, convert it to an integer, assign it to a variable
                int second = int.Parse(Console.ReadLine());

                //Print text to the console, ending with a call to a method of the Methods class.
                Console.WriteLine("add(" + first + ", " + second +"): " + n.AddTwo(first, second));
            }
            //otherwise just call with the first.
            catch
            {
                //Print text to the console, ending with a call to a method of the Methods class.
                Console.WriteLine("add(" + first + "): " + n.AddTwo(first));
            }
        }
    }
}
