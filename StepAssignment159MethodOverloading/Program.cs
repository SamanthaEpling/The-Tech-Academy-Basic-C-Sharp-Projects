using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment159MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick your favorite whole number.");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose: " + givenNumber + ".");
            Console.WriteLine("Press enter to multiply " + givenNumber + " by 10.");
            Console.ReadLine();
            Console.WriteLine(Methods.TimesTen(givenNumber));

            Console.WriteLine("Now pick your favorite decimal number.");
            decimal givenNumber2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("You chose: " + givenNumber2 + ".");
            Console.WriteLine("Press enter to divide " + givenNumber2 + " by 4 and get the nearest integer.");
            Console.ReadLine();
            Console.WriteLine(Methods.TimesTen(givenNumber2));

            Console.WriteLine("Pick your favorite string number.");
            int givenNumber3 = Convert.ToInt32(Console.ReadLine());
            int givenNumber4 = givenNumber3;
            Console.WriteLine("You chose to multiply " + givenNumber3 + " by itself.");
            Console.ReadLine();
            Console.WriteLine(Methods.TimesTen(givenNumber3, givenNumber4));
            Console.WriteLine("Thanks for playing my little C# game!");
            Console.ReadLine();
        }
    }
}
