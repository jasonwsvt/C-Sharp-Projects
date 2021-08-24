using System;
using System.Linq;

namespace While_and_Do_While
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            Console.WriteLine("The computer will now try to guess a random number between 0 and 10.");

            //Assigning a variable for the secret number.
            float number = 0;

            //Assigning a variable for the guessed number.
            float guess;

            //Assigning an array of floats for the previously guessed numbers.
            float[] guesses = { };

            //Secretly determine a number with a while loop (do while would be more appropriate here)
            //Continues until the random number is not 0.
            while (number == 0)
            {
                //Generating a new secret number between 0 and 10.
                number = (float) Math.Floor(random.NextDouble() * 10000) / 1000;
            }

            //Guess the number with a do while loop
            do
            {
                //Resize the array to be one larger than the current size.
                Array.Resize(ref guesses, guesses.Length + 1);

                //A do while loop to determine a number that hasn't yet been guessed.
                do
                {
                    guess = (float) Math.Floor(random.NextDouble() * 10000) / 1000;
                }
                while (guesses.Contains(guess));

                //Assign the new guess to the end of the array.
                guesses[^1] = guess;

                //Ask if the guess is the correct number.
                Console.WriteLine("Is " + guess + " the correct number?");

                //If the guessed number is not the secret number
                if (guess != number)
                {
                    //Print this the screen.
                    Console.WriteLine("I'm sorry.  " + guess + " is not correct.  Please try again.");
                }
            }
            while (guess != number);

            //Once the guessed number is equal to the secret number, print this message to the screen.
            Console.WriteLine("Congratulations!  " + guess + " is correct!  It only took you " + guesses.Length + " tr" + ((guesses.Length == 1) ? "y" : "ies") + ".");
        }
    }
}
