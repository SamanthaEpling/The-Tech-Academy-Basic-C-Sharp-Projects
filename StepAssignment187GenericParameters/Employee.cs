using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment176AbstractBaseClasses
{
    public class Employee <T> : Person 
    {
        
        public List<T> Things { get; set; }
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + ".");
        }



    }
}
