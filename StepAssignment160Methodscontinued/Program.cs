using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment160Methodscontinued
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick your favorite whole number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose: " + numberOne + " for your first number.");
            Console.WriteLine("You may choose a second number or leave it blank.");
            string numberTwo = Console.ReadLine();
            int optionTwo = 0;
            if (numberTwo == "")
            {
                numberTwo = "0";
                optionTwo = Convert.ToInt32(numberTwo);
            }
            else
            {
                optionTwo = Convert.ToInt32(numberTwo);
            }
            Console.WriteLine("Now, their sum!:");
            Console.WriteLine(Method.AddTwo(numberOne, optionTwo));
            Console.ReadLine();
        }
    }
}
