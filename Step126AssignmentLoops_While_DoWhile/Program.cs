using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126AssignmentLoops_While_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //========Section 1: While Loop========

            Console.WriteLine("Guess a pet name?:");
            string name = Console.ReadLine();
            bool isGuessed = false;

            while (!isGuessed)
            {
                switch (name)
                {
                    case "Lionel":
                        Console.WriteLine("You guessed Lionel. Try again.");
                        Console.WriteLine("Guess a pet name?:");
                        name = Console.ReadLine();
                        break;
                    case "Romani":
                        Console.WriteLine("You guessed Romani. Try again.");
                        Console.WriteLine("Guess a pet name?:");
                        name = Console.ReadLine();
                        break;
                    case "Hermione":
                        Console.WriteLine("You guessed Hermione.  That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("While there are many pet names to choose from, you didn't guess right!");
                        Console.WriteLine("Guess a pet name?:");
                        name = Console.ReadLine();
                        break;
                }
            }
            Console.Read();
        }

            //========Section 2: Do While Loop========



        //{
            //Console.WriteLine("Guess a pet name?:");
            //string name = Console.ReadLine();
            //bool isGuessed = name == "Hermione";

            //do
            //{
            //    switch (name)
            //    {
            //        case "Lionel":
            //            Console.WriteLine("You guessed Lionel. Try again.");
            //            Console.WriteLine("Guess a pet name?:");
            //            name = Console.ReadLine();
            //            break;
            //        case "Romani":
            //            Console.WriteLine("You guessed Romani. Try again.");
            //            Console.WriteLine("Guess a pet name?:");
            //            name = Console.ReadLine();
            //            break;
            //        case "Hermione":
            //            Console.WriteLine("You guessed Hermione. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("While there are many pet names to choose from, you didn't guess right!");
            //            Console.WriteLine("Guess a pet name?:");
            //            name = Console.ReadLine();
            //            break;
            //    }
            //}

            //while (!isGuessed);

            //Console.Read();

        //}
    }
}
