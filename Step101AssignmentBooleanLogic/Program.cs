using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step101AssignmentBooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int AppAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool AppDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int AppTick = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool Qual_Age = AppAge >= 15.00;
            bool Qual_DUI = !AppDUI;
            bool Qual_Tick = AppTick <= 3;
            bool Qual_App = Qual_Age && Qual_Tick && Qual_DUI;
            string Qualified = Convert.ToString(Qual_App);
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
