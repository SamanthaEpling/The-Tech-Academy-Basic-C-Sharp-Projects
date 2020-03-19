using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StepAssignment218FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number...");
            string answer = Console.ReadLine();
            // I chose to keep the answer from the user as a string incase of non-integer answers....
            File.WriteAllText(@"C:\Users\Student\Desktop\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\CourseWork\TwentyOne\Logs\log_218.txt", "Initial answer from user: " + answer);
            Console.WriteLine("Based on your above answer, what is written below was saved to a txt file that says:");
            string text = File.ReadAllText(@"C:\Users\Student\Desktop\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\CourseWork\TwentyOne\Logs\log_218.txt");
            Console.WriteLine(text + "\r\nThanks for playing my little game!");
            Console.ReadLine();
        }
    }
}
