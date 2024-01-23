using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RihTools.Extension
{
    public static class StringExt
    {
        public static bool IsNullOrEmptyOrZero(this string str)
        {
            return (str is null) || (str == string.Empty) || (str.Length == 0) || str.Equals("0");
        }
    }
}
