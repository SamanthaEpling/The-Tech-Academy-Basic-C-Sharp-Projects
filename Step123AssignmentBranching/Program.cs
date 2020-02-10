using System;

namespace Step123AssignmentBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal p_weight = Convert.ToDecimal(Console.ReadLine());
            if (p_weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                decimal p_width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                decimal p_height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal p_length = Convert.ToDecimal(Console.ReadLine());
                
                if ((p_width > 50) && (p_height > 50) && (p_length > 50))
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    decimal p_cost = (p_width * p_height * p_length * p_weight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + p_cost + ".");
                    Console.ReadLine();
                }
            }
        }
    }
}
