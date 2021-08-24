using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());
            if (width > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());
            if (width + height > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            Console.WriteLine("Your estimated total for shipping this package is: " + string.Format("{0:C}", height * width * length * weight / 100));
            Console.WriteLine("Thank you!");
        }
    }
}
