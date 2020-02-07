using System;


namespace Step72AssignmentforCSharpand.NETFrameworkCourse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string CourseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string CourseNum = Console.ReadLine();
            int CourseNumber = Convert.ToInt32(CourseNum);

            Console.WriteLine("Do you need help with anything? Please answer \"True\"or \"False.\"");
            string AdditionalHelp = Console.ReadLine();
            bool HelpNeeded = Convert.ToBoolean(AdditionalHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string CourseExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string CourseFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string HoursStudied = Console.ReadLine();
            int TimeStudied = Convert.ToInt32(HoursStudied);

            Console.WriteLine("Thank you for your answers.  An Instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();
        }
    }
}
