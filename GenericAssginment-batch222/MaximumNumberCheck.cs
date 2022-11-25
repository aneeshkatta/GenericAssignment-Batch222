using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment_batch222
{
    internal class MaximumNumberCheck
    {
        public static string MaximumString(string firstValue, string secondValue, string thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            else
                return firstValue;
        }
        public static void Main()
        {
            Console.WriteLine("Welcome to Generic's Maximum Number Check");
            Console.WriteLine("Enter three string's and find the max string");
            Console.WriteLine("Enter first String");
            string x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second String");
            string y = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter third String");
            string z = Convert.ToString(Console.ReadLine());
            string output = MaximumNumberCheck.MaximumString(x, y, z);
            Console.WriteLine(output + " is Maximum string");
            Console.ReadKey();
        }

    }
}
