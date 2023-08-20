using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            int a = 10, b = 5;
            result = a + b;
            Console.WriteLine("Sum: " + result);
            result = a - b;
            Console.WriteLine("Difference: " + result);
            result = a * b;
            Console.WriteLine("Product: " + result);
            result = a / b;
            Console.WriteLine("Quotient: " + result);
            Console.ReadLine();
        }
    }
}
