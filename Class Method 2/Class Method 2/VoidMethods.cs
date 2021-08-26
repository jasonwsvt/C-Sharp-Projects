using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Method_2
{
    class VoidMethods
    {
        //Void method outputs an integer.
        public void VM(ref int num)
        {
            //Divide the argument by 2
            num /= 2;
        }

        //Create an overloaded method with output parameters.
        public void VM(ref int one, ref int two)
        {
            one *= 2;
            two /= 2;
        }
    }
}
