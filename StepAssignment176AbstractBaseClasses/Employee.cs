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


        public static bool operator== (Employee employee1, Employee employee2)
        {
            bool Same = true;
            Same = (employee1.Id == employee2.Id);
            return Same;
        }

        public static bool operator!= (Employee employee1, Employee employee2)
        {
            bool Same = true;
            Same = (employee1.Id != employee2.Id);
            return Same;
        }
    }
}
