using System;

namespace Main_Method
{
    class Program
    {
        static void Main()
        {
            MathOperations mos = new MathOperations();

            Console.WriteLine("RandFunc(10): " + mos.RandFunc(10));
            Console.WriteLine("RandFunc(34.1254453): " + mos.RandFunc(34.1254453m));
            Console.WriteLine("RandFunc(\"300\"): " + mos.RandFunc("300"));
        }
    }
}
