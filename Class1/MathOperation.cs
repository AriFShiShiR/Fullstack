using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmatic
{
    internal class MathOperation
    {

        public void sum2(int number1, int number2)
        {
            int ruselt = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is: {ruselt}");
        }

        public void Sum()
        {
            int number1 = 10;
            int number2 = 20;
            int result = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is: {result}");
        }
        public int Subtract()
        {
            Console.WriteLine("Enter the first number:");
            int number1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            int number2 =int.Parse(Console.ReadLine());
            int result = number1 - number2;
            return result;
        }
    }
}
