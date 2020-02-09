using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step90AssignmentMathandComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal P1Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal P1Hours = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal P2Rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal P2Hours = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            decimal P1Salary = 12 * (P1Rate * P1Hours);
            Console.WriteLine(P1Salary);
            Console.WriteLine("Annual salary of Person 2:");
            decimal P2Salary = 12 * (P2Rate * P2Hours);
            Console.WriteLine(P2Salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool P1SalGTP2Sal = P1Salary > P2Salary;
            Console.WriteLine(P1SalGTP2Sal);
            Console.ReadLine();
        }
    }
}
