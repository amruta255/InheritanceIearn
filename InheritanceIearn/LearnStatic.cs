using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIearn
{
    public static class LearnStatic
    {
        public static string UpdateFirst(this Chef s)
        {
            
            return s.name.ToUpper();
        }
    }
}
