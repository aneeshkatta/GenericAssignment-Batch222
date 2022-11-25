using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment_batch222
{
    class GenericMaximumCheck<T> where T : IComparable
    {//constructor
        public T[] value;
        public GenericMaximumCheck(T[] value)
        {
            this.value = value;
        }
        //sort values in arrays
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T Maxvalue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public void PrintMaxValue()
        {
            var max = Maxvalue(this.value);
            Console.WriteLine("Maximum value is :" + max);

        }

    }
}
