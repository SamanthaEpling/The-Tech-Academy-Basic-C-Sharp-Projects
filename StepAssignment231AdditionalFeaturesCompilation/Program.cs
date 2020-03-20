using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment231AdditionalFeaturesCompilation
{
    class Program
    {
        static void Main(string[] args)
        {
            //===== Section 1: Create a const variable =====
            const string familyName = "Barking Mad Farms";
            Console.WriteLine("Welcome to {0}! Where we are mad to have so many pets!\r\n", familyName);
            //===== Section 2: Create a variable using "var" =====
            var numberPets = 6;
            Console.WriteLine("Currently we have {0} pets!\r\n", numberPets);
            //===== Section 3: Chain two constructors together =====
            string name = "Lionel";
            Pets pet = new Pets(name);
            Console.WriteLine("The latest pet to join our crew, {0} makes the minimum age of all the pets {1} years old.", pet.Name, pet.Age);
            Console.ReadLine();
        }
    }
}
