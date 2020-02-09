using System;

namespace Step89AssignmentMathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type a whole number and we will multiply it by 50: ");
            string ChosenNumber = Console.ReadLine();
            int ChosNum = Convert.ToInt32(ChosenNumber);
            int product = ChosNum * 50;
            Console.WriteLine("The product is: "+ product + ".");
            Console.ReadLine();

            Console.WriteLine("Type a number and we will add 25: ");
            string ChosenNumber2 = Console.ReadLine();
            double ChosNum2 = Convert.ToDouble(ChosenNumber2);
            double sum = ChosNum2 + 25;
            Console.WriteLine("The product is: " + sum + ".");
            Console.ReadLine();

            Console.WriteLine("Type a number and we will divide it by 12.5: ");
            string ChosenNumber3 = Console.ReadLine();
            double ChosNum3 = Convert.ToDouble(ChosenNumber3);
            double quotient = ChosNum3 / 12.5;
            Console.WriteLine("The result is: " + quotient + ".");
            Console.ReadLine();

            Console.WriteLine("Type a number and we will tell you if it is greater than 50: ");
            string ChosenNumber4 = Console.ReadLine();
            bool trueOrFalse = Convert.ToInt32(ChosenNumber4) > 50;
            Console.WriteLine("The statement " + ChosenNumber4 + " is greater than 50 is: "+ trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Type a number and we will give you the remainder after dividing by seven:");
            string ChosenNumber5 = Console.ReadLine();
            int remainder = Convert.ToInt32(ChosenNumber5) % 7;
            Console.WriteLine("When you divide " + ChosenNumber5 + " by 7, you have a remainder of: "+ remainder + ".");
            Console.ReadLine();
        }
    }
}
