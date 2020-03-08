using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StepAssignment156_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick your favorite whole number.");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You chose: " + givenNumber + ".");
            Console.WriteLine("Press enter to multiply " + givenNumber + " by 10.");
            Console.ReadLine();
            Console.WriteLine(Operation1.TimesTen(givenNumber));
            Console.ReadLine();
            Console.WriteLine("Press enter to square " + givenNumber + ".");
            Console.ReadLine();
            Console.WriteLine(Operation2.SquareIt(givenNumber));
            Console.ReadLine();
            Console.WriteLine("Press enter to multiply " + givenNumber + " by 20.");
            Console.ReadLine();
            Console.WriteLine(Operation3.TimesTwenty(givenNumber));
            Console.WriteLine("Thanks for playing my little game!");
            Console.ReadLine();

            
        }
    }
}
