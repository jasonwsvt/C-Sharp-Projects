using System;
using System.Collections.Generic;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main()
        {
            //Assign an array of integers to a ushort list.
            List<ushort> numList = new List<ushort> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Print text to the console.
            Console.Write("Please enter an integer: ");

            //Assign an initial value to a variable of integer type.
            float denominator = 0f;

            //Begin a loop
            do
            {
                //Begin a try / catch block
                try
                {
                    //Convert user input to a float and assign it to denominator.
                    denominator = float.Parse(Console.ReadLine());

                    //Catch the divide by zero error before it would occur.
                    if (denominator == 0f)
                    {
                        Console.Write("Please enter a non-zero number: ");
                    }
                }
                //Catch the error on read that might occur if a number wasn't entered.
                catch (FormatException)
                {
                    Console.Write("Please enter a valid number: ");
                }
                //Catch the error on read that might occur if the number is greater than 
                catch (OverflowException)
                {
                    Console.Write("Please enter a number below " + float.MaxValue.ToString("#") + ": ");
                }
            }
            //repeat until a valid number is entered.
            while (denominator == 0f);

            //Print out the fraction of each number in the numList list divided by the entered denominator.
            foreach (ushort num in numList)
            {
                Console.WriteLine(num + " / " + denominator + " = " + num / denominator);
            }
        }
    }
}
