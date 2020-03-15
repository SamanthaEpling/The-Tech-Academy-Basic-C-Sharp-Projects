using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment192Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string chosenDay = Console.ReadLine();
                string chosenday = chosenDay.ToLower();
                Name name = (Name)Enum.Parse(typeof(Name), chosenday);
                if (name == Name.monday)
                {
                    Console.WriteLine("Happy Monday!");
                }
                else if (name == Name.tuesday)
                {
                    Console.WriteLine("Happy Tuesday!");
                }
                else if (name == Name.wednesday)
                {
                    Console.WriteLine("Happy Wednesday!");
                }
                else if (name == Name.thursday)
                {
                    Console.WriteLine("Happy Thursday!");
                }
                else if (name == Name.friday)
                {
                    Console.WriteLine("Happy Friday!");
                }
                else if (name == Name.saturday)
                {
                    Console.WriteLine("Happy Saturday!");
                }
                else if (name == Name.sunday)
                {
                    Console.WriteLine("Happy Sunday!");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
