using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmatic
{
    internal class MathOperation
    {
        public void Sum()
        {
            Console.WriteLine("Enter first number:");
        }

        public void sum2(int number1, int number2)
        {
            int ruselt = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is: {ruselt}");
        }
    }
}
