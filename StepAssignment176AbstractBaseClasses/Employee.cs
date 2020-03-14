using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
{
    public class Employee : Person
    {
        
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + ".");
        }


        public static Person operator== (Employee employee, bool Same)
        {
            Same = (employee.Id == employee.Id);
            Convert.ToString(Same);
            return Same;
        }

        public static Person operator!= (Employee employee, bool Same)
        {
            Same = (employee.Id != employee.Id);
            Convert.ToString(Same);
            return Same;
        }
    }
}
