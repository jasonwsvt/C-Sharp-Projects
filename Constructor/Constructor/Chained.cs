using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Chained
    {
        //Chain two constructors together.
        public Chained(): this("chained")
        {
        }
        public Chained(string s)
        {
            Str = s;
        }
        public string Str;
    }
}
