using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.Helper
{
    internal static class BoolLogic
    {
        public static bool equivalention(bool a, bool b)
        {
            return (a && b) || (!a && !b);
        }
    }
}
