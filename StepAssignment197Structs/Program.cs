using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment197Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number1 = new Number();
            number1.Amount = 3.14159265M;

            Console.WriteLine("Happy Pi day! Pi is: " + number1.Amount);
            Console.ReadLine();
        }
    }
}
