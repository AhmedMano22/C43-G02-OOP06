using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment06.project2
{
    internal class Maths
    {
        // Add 
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Subtract 
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiply
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Divide
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Sorry Cannot divide by zero....");
            }
            return a / b;
        }
    }
}
