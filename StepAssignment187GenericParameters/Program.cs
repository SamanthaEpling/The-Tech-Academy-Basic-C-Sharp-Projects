using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
// For StepAssignment187Generics
{     
    class Program
    {
        public static void Main(string[] args)
        {
            //==============="string" type generic parameter================

            //Employee<string> employee = new Employee<string>();
            //employee.lastName = "Student";
            //employee.firstName = "Sample";

            //employee.SayName();           
            //employee.Things = new List<string>() { "thing a", "thing b", "thing c", "thing d", "thing e" };

            //Console.WriteLine("Employee Things: \r\n");
            //foreach (string thing in employee.Things)
            //{
            //Console.WriteLine( thing + "\r\n");
            //}            
            //Console.ReadLine();

            //==============="int" type generic parameter================

            Employee<int> employee = new Employee<int>();
            employee.lastName = "Student";
            employee.firstName = "Sample";

            employee.SayName();
            employee.Things = new List<int>() { 20, 43, 37, 28, 55 };

            Console.WriteLine("Employee Things: \r\n");
            foreach (int thing in employee.Things)
            {
                Console.WriteLine(thing + "\r\n");
            }
            Console.ReadLine();

        }
    }
}
