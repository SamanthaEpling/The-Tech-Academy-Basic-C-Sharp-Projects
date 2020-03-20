using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StepAssignment221DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            
            Console.WriteLine("The current time is: " + currentTime.ToString() + "\r\n\nType in an integer and let us calculate what time it will be in that many hours...\r\n");
            double answer = Convert.ToDouble(Console.ReadLine());
            DateTime futureTime = currentTime.AddHours(answer);
            Console.WriteLine("\r\n" + futureTime + " is " + answer + " hours away from " + currentTime + ".\r\n\nThanks for looking into the future with us!");
            Console.ReadLine();
        }
    }
}
