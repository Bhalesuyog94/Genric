using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericsClass
    {
        public class GenericMaximum<T> where T : IComparable
        {
            public T[] value;

            public GenericMaximum(T[] value)
            {
                this.value = value;
            }
            public T[] sort(T[] values)
            {
                Array.Sort(values);
                return values;
            }
            public T MaxValue(params T[] values)
            {
                var sorted_values = sort(values);
                return sorted_values[^1];
            }
            public void PrintMaxvalue()
            {
                var max = MaxValue(this.value);
                Console.WriteLine("Maximum vaule is " +max);
            }
        }
    }
}
