using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.lastName = "Student";
            employee.firstName = "Sample";
            employee.SayName();
            Console.ReadLine();
        }
    }
}
