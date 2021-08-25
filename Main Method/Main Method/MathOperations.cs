using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    class MathOperations
    {
        public int RandFunc(int n)
        {
            //Creates a new random number generator
            Random r = new Random();

            //returns a random integer between 0 and n
            return (int)Math.Floor(r.NextDouble() * n);
        }
        public decimal RandFunc(decimal n)
        {
            //Creates a new random number generator
            Random r = new Random();

            //Converts the number to a string
            string strN = n.ToString();

            //Calculates the number of decimal places by the index of the decimal, or 0 if none
            int decimalPlaces = strN.Contains(".") ? strN.Length - strN.IndexOf(".") - 1 : 0;

            //Calculates the number (10^n) to multiply and divide by
            int power = (int)Math.Pow(10, decimalPlaces);

            //Return a random number of the same precision between 0 and n
            return (decimal)(Math.Floor((decimal)r.NextDouble() * n * (decimal)power) / (decimal)power);
        }
        public int RandFunc(string n)
        {
            //If n is an integer,
            if (int.TryParse(n, out _)) {
                //Return the result of the integer function.
                return RandFunc(int.Parse(n));
            }
            //If n is a decimal number,
            else if (decimal.TryParse(n, out _))
            {
                //Return the result of the decimal function, converted to an integer.
                return (int)RandFunc(decimal.Parse(n));
            }
            //If not an integer or a decimal, return 0.
            return 0;
        }
    }
}
