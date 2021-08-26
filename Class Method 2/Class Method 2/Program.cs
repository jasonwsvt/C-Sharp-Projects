using System;

namespace Class_Method_2
{
    class Program
    {
        //Declare a class to be static.
        static void Main()
        {
            //Instantiate the VoidMethods class
            VoidMethods vm = new VoidMethods();
            int num;
            bool valid = false;

            Console.Write("Please enter an integer: ");
            do
            {
                try
                {
                    //Have user enter a number
                    num = int.Parse(Console.ReadLine());
                    valid = true;
                    //Call the method with the number.
                    vm.VM(ref num);

                    //Display the output to the screen.  It should be the entered number, divided by two.
                    Console.WriteLine("The integer's value following the method call: " + num);
                }
                catch
                {
                    Console.Write("Please enter a valid integer: ");
                }
            }
            while (!valid);
        }
    }
}
