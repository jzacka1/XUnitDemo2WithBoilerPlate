using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator calc = new Calculator.Calculator();

            int x = 4, y = 2;

            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, calc.Add(x, y));

            Console.WriteLine("The difference of {0} and {1} is {2}", x, y, calc.Subtract(x, y));

            Console.WriteLine("The product of {0} and {1} is {2}", x, y, calc.Multiply(x, y));

            //This is a test
            Console.WriteLine("The quotient of {0} and {1} is {2}", x, y, calc.Divide(x, y));
        }
    }
}
