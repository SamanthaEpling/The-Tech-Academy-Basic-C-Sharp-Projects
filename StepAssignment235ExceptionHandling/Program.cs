using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment235ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please input your age in the next line: ");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                int yearOfBirth = 2020 - answer;
                Console.WriteLine("You were born in the year: " + yearOfBirth + "\r\nThank you for playing!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The input value was not a whole integer.");
            }
            
            catch (Exception)
            {
                Console.WriteLine("An error has occured.  Please contact your System Administrator.");
            }
            
            Console.ReadLine();
            
        }
    }
}
