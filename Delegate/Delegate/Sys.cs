using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Sys
    {
        public delegate void func();

        public static void Count(func y)
        {
            y();
        }
    }
}
