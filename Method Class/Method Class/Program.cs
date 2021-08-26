using System;

namespace Method_Class
{
    class Program
    {
        static void Main()
        {
            //Create an instance of VoidMethod
            VoidMethod vm = new VoidMethod();

            //Call the VoidMethod method with two parameters.
            vm.VM(4, 5);

            //Call the same method with named parameters.
            vm.VM(two: 5, one: 4);
        }
    }
}
