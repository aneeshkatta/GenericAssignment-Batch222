using GenericAssignment_batch222;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssginment_batch222
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Generic's Maximum Number Check");
            MaximumNumberCheck<int>.FindMax(20, 30, 40);
            MaximumNumberCheck<double>.FindMax(50.99, 30.36, 70.99);
            MaximumNumberCheck<string>.FindMax("Apple", "Peach", "Banana");
            Console.ReadKey();
        }
    }
}
