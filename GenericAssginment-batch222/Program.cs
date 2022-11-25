using GenericAssignment_batch222;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssginment_batch222
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic's Maximum Check");
            int[] intarray = { 60, 30, 40 };
            GenericMaximumCheck<int> generic = new GenericMaximumCheck<int>(intarray);
            generic.PrintMaxValue();
            double[] doublearray = { 120.6985, 30.35585, 40.24586 };
            GenericMaximumCheck<double> generic1 = new GenericMaximumCheck<double>(doublearray);
            generic1.PrintMaxValue();
            string[] stringarray = { "Apple", "Peach", "Banana" };
            GenericMaximumCheck<string> generic2 = new GenericMaximumCheck<string>(stringarray);
            generic2.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
