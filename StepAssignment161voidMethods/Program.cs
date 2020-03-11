using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment161voidMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide a second integer: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating..,\r\n");
            bool result;
            Methods.Calc1(numberOne, numberTwo, out result);
            Convert.ToString(result);
            Console.WriteLine("The square of the first number is larger than the square of " + numberTwo + ": \r\n" + result);
            Console.ReadLine();

        }
    }
}
