using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            //Creating a variable of type ushort for use throughout.
            ushort index;

            //Creating an array of type string, and assigning an array of ten strings to it.
            string[] stringArray = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
 
            //Start a loop
            do
            {
                //Print a string of text to the console.
                Console.WriteLine("Please select an index of the string array (0 - 9):");

                //Read user-entered data, convert it to a ushort, and assign it to the variable.
                index = ushort.Parse(Console.ReadLine());

                //If the value of index is invalid (below 0 or above the length of the string)
                if (index < 0 || index > stringArray.Length - 1)
                {
                    //Print a string of text to the console.
                    Console.WriteLine("Sorry, that integer is outside of the range of 0 - 9.  Please try again.");
                }
            }
            //Continue until a valid index is read.
            while (index < 0 || index > stringArray.Length - 1);

            //Print a string of text to the console.
            Console.WriteLine("The string at index " + index + " is " + stringArray[index] + ".");


            //Creating an array of type int, and assigning an array of ten integers to it.
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Start a loop
            do
            {
                //Print a string of text to the console.
                Console.WriteLine("Please select an index of the integer array (0 - 9):");

                //Read user-entered data, convert it to a ushort, and assign it to the variable.
                index = ushort.Parse(Console.ReadLine());

                //If the value of index is invalid (below 0 or above the length of the string)
                if (index < 0 || index > intArray.Length - 1)
                {
                    //Print a string of text to the console.
                    Console.WriteLine("Sorry, that integer is outside of the range of 0 - 9.  Please try again.");
                }
            }
            //Continue until a valid index is read.
            while (index < 0 || index > stringArray.Length - 1);

            //Print a string of text to the console.
            Console.WriteLine("The integer at index " + index + " is " + intArray[index] + ".");


            //Creating a list of type string, and assigning an array of ten strings to it.
            List<string> stringList = new List<string> { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            //Start a loop.
            do
            {
                //Print a string of text to the console.
                Console.WriteLine("Please select an index of the string list (0 - 9):");

                //Read user-entered data, convert it to a ushort, and assign it to the variable.
                index = ushort.Parse(Console.ReadLine());

                //If the value of index is invalid (below 0 or above the length of the string)
                if (index < 0 || index > stringArray.Length - 1)
                {
                    //Print a string of text to the console.
                    Console.WriteLine("Sorry, that integer is outside of the range of 0 - 9.  Please try again.");
                }
            }
            //Continue until a valid index is read.
            while (index < 0 || index > stringArray.Length - 1);

            //Print a string of text to the console.
            Console.WriteLine("The string at index " + index + " is " + stringList[index] + ".");
        }
    }
}
