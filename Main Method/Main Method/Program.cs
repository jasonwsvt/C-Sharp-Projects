using System;

namespace Main_Method
{
    class Program
    {
        static void Main()
        {
            //Create an instantiation of the MathOperations class.
            MathOperations mos = new MathOperations();

            //Write the result of the integer RandFunc method to the console.
            Console.WriteLine("RandFunc(10): " + mos.RandFunc(10));

            //Write the result of the decimal RandFunc method to the console.
            Console.WriteLine("RandFunc(34.1254453): " + mos.RandFunc(34.1254453m));

            //Write the result of the string RandFunc method to the console.
            Console.WriteLine("RandFunc(\"300\"): " + mos.RandFunc("300"));
        }
    }
}
