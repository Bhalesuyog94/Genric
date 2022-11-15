using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaximumStrings
    {
        public static string MaximumString(string firstvalue, string secondvalue, string thridvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thridvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) >= 0 && firstvalue.CompareTo(thridvalue) > 0 ||
                firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thridvalue) >= 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thridvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) >= 0 && secondvalue.CompareTo(thridvalue) > 0 ||
                secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thridvalue) >= 0)
            {
                return secondvalue;
            }
            if (thridvalue.CompareTo(firstvalue) > 0 && thridvalue.CompareTo(secondvalue) > 0 ||
                thridvalue.CompareTo(firstvalue) >= 0 && thridvalue.CompareTo(secondvalue) > 0 ||
                thridvalue.CompareTo(firstvalue) > 0 && thridvalue.CompareTo(secondvalue) >= 0)
            {
                return thridvalue;
            }
            return firstvalue;
        }
    }
}
