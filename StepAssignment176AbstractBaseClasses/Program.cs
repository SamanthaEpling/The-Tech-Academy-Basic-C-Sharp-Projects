using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
    // For StepAssignment184Overloading the "==" Comparison Operator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.lastName = "Student";
            employee.firstName = "Sample";

            employee.SayName();


            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 0;

            employee2.Id = 1;
            
            
            Console.WriteLine("Employee Id's match: " + (employee1 == employee2));
            Console.ReadLine();
        }
    }
}
