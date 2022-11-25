using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment_batch222
{
    internal class MaximumNumberCheck
    {
        public static double MaximumDoubleNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return +firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return +secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return +thirdValue;
            }
            else
                return firstValue;
        }
        public static void Main()
        {
            Console.WriteLine("Welcome to Generic's Maximum Number Check");
            Console.WriteLine("Enter three double values and find the max Number");
            Console.WriteLine("Enter firstValue");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter secondValue");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter thirdValue");
            double z = Convert.ToDouble(Console.ReadLine());
            double output = MaximumNumberCheck.MaximumDoubleNumber(x, y, z);
            Console.WriteLine(output + " is Maximum number");
            Console.ReadKey();
        }

    }
}
