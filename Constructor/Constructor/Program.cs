using System;
using System.Collections.Generic;

namespace Constructor
{
    class Program
    {
        static void Main(int num)
        {
            //Create a const variable.
            const int constInt = 1;

            //Create a variable using the keyword “var.”
            var intList = new List<int>(constInt);

            //Two instantiations of a class with chained constructors.
            Chained chained1 = new Chained();
            Console.WriteLine(chained1.Str);

            Chained chained2 = new Chained("stuff");
            Console.WriteLine(chained2.Str);
        }
    }
}
