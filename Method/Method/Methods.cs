using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class Methods
    {
        //If the second parameter is not provided, give it a default value of 0.
        public int AddTwo(int one, int two = 0)
        {
            //Return the sum of both parameters.
            return one + two;
        }
    }
}
