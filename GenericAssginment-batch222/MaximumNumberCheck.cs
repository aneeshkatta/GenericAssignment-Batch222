using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment_batch222
{
    internal class MaximumNumberCheck
    {
        public static int MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
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
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return +thirdValue;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");

        }
        public static void Main()
        {
            Console.WriteLine("Welcome to Generic's Maximum Number Check");
            Console.WriteLine("Enter three integer values find the max Number");
            Console.WriteLine("Enter firstValue");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secondValue");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter thirdValue");
            int z = Convert.ToInt32(Console.ReadLine());
            int output = MaximumNumberCheck.MaximumIntegerNumber(x, y, z);
            Console.WriteLine(output + " is Maximum number");
            Console.ReadKey();
        }

    }
}
