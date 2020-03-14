using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
    // For StepAssignment179InterfaceClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.lastName = "Student";
            employee.firstName = "Sample";

            employee.SayName();

            employee.Id = 0;
            employee.Id = 1;
            bool Same = employee.Id == employee.Id;
            Convert.ToString(Same);
            Console.WriteLine("Employee Id's match: " + Same);
            Console.ReadLine();
        }
    }
}
