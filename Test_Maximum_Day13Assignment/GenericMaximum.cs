using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumUsingGeneric_Day13Assignment
{

    public class GenericMaximum<T> where T : IComparable
    { 
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }

        public T[] Sort()
        {
            Array.Sort(value);
            return value;

        }
        public void display()
        {
            foreach( var a in value)
            {
                Console.WriteLine(a);
            }
        }

        public T MaxValue()
        {
            var sorted_values = Sort();

            return sorted_values[sorted_values.Length - 1];
        }

        public void PrintMaxValue()
        {
            var max = MaxValue();
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
