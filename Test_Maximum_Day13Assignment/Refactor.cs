using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxNumUsingGeneric_Day13Assignment
{
    internal class Refactor<T>
    {
        public T firstValue, secondValue, thirdValue;

        public Refactor( T firstValue, T secondValue, T thirdValue )
        {
             this.firstValue = firstValue;
             this.secondValue = secondValue;
             this.thirdValue = thirdValue;
        }

        public T MaxValue(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }

            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
               secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }

            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
               thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
               thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;
        } 
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    public T MaxMethod()
    {
        T max = Refactor<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);
        return max;
    }
    }
}
