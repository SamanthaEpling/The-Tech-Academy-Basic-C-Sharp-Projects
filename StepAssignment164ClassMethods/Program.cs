using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment164ClassMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please provide an integer: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating your integer's half.....\r\n");
            int result;
            Methods.DivideByTwo(numberOne, out result);
            Console.WriteLine("Half of your integer is: " + result + ".\r\n");
            Console.WriteLine("But wait! \r\nThere's more! \r\nPlease provide another integer: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating your integer's value if multiplied by a quarter......\r\n");
            int result2;
            Methods.DivideByQuarter(numberTwo, out result2);
            Console.WriteLine("The result of multiplying your integer by a quarter is: \r\n" + result2 + ".");
            Console.WriteLine("But wait! \r\nThere is even more! \r\nPlease provide another integer: ");
            decimal numberThree = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Calculating your a quarter of your integer....");
            decimal result3;
            Methods.DivideByQuarter(numberThree, out result3);
            Console.WriteLine("The result of dividing your integer by four is: \r\n" + result3 + ".\r\n" +
                "Thanks for playing my little game.");
            Console.ReadLine();
        }
    }
}
