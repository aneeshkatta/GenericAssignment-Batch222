﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment_batch222
{
    class GenericMaximumNumberCheck<T> where T : IComparable
    {
        public T firstvalue, secondvalue, thirdvalue;
        public GenericMaximumNumberCheck(T firstValue, T secondValue, T thirdValue)
        {
            this.firstvalue = firstvalue;
            this.secondvalue = secondvalue;
            this.thirdvalue = thirdvalue;

        }
        public static T FindMax(T firstValue, T secondValue, T thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine($"{firstValue}  is greater in {firstValue}, {secondValue},{thirdValue} ");
                
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                Console.WriteLine($"{secondValue}  is greater in {firstValue}, {secondValue},{thirdValue} ");
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                Console.WriteLine($"{thirdValue}  is greater in {firstValue}, {secondValue},{thirdValue} ");
            }
            else
                Console.WriteLine($"{firstValue}  is greater ");
            return default;
        }
        public T TestMaxMethod()
        {
            T max = GenericMaximumNumberCheck<T>.FindMax(this.firstvalue, this.secondvalue, this.thirdvalue);
            return max;
        }


    }
}
