using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepAssignment202LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            // ======================= Sections 1 & 2: using the foreach loop ============================


            List<string> Employee = new List<string>();
            List<string> JoeList = new List<string>();

            Employee employee1 = new Employee();
            employee1.fName = "Joe";
            employee1.lName = "Smith";
            employee1.IDnumber = 1;
            Employee employee2 = new Employee();
            employee2.fName = "Joe";
            employee2.lName = "Brown";
            employee2.IDnumber = 2;
            Employee employee3 = new Employee();
            employee3.fName = "Leo";
            employee3.lName = "NinjaTurtle";
            employee3.IDnumber = 3;
            Employee employee4 = new Employee();
            employee4.fName = "Don";
            employee4.lName = "NinjaTurtle";
            employee4.IDnumber = 4;
            Employee employee5 = new Employee();
            employee5.fName = "Raf";
            employee5.lName = "NinjaTurtle";
            employee5.IDnumber = 5;
            Employee employee6 = new Employee();
            employee6.fName = "Mike";
            employee6.lName = "NinjaTurtle";
            employee6.IDnumber = 6;
            Employee employee7 = new Employee();
            employee7.fName = "Milo";
            employee7.lName = "Adventurer";
            employee7.IDnumber = 7;
            Employee employee8 = new Employee();
            employee8.fName = "Otis";
            employee8.lName = "Adventurer";
            employee8.IDnumber = 8;
            Employee employee9 = new Employee();
            employee9.fName = "Trigger";
            employee9.lName = "Rogers";
            employee9.IDnumber = 9;
            Employee employee10 = new Employee();
            employee10.fName = "Dug";
            employee10.lName = "Up";
            employee10.IDnumber = 10;

            List<string> EmpFirstNames = new List<string>();
            EmpFirstNames.Add(employee1.fName);
            EmpFirstNames.Add(employee2.fName);
            EmpFirstNames.Add(employee3.fName);
            EmpFirstNames.Add(employee4.fName);
            EmpFirstNames.Add(employee5.fName);
            EmpFirstNames.Add(employee6.fName);
            EmpFirstNames.Add(employee7.fName);
            EmpFirstNames.Add(employee8.fName);
            EmpFirstNames.Add(employee9.fName);
            EmpFirstNames.Add(employee10.fName);



            // foreach loop for section 2...

            //foreach (string fname in EmpFirstNames)
            //{
            //    if (fname == "Joe")
            //    {
            //        JoeList.Add(fname);
            //    }
            //}
            //foreach (string name in JoeList)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();



            // ======================= Sections 3: using the lambda expression ============================


            //JoeList = EmpFirstNames.Where(x => x.Contains("Joe")).ToList();
            //foreach (string name in JoeList)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();


            // ======================= Sections 4: using the lambda expression ============================

            JoeList = .Where(x => x > 5).ToList();
            foreach (string fName, string lName, int IDnumber in Employee)
            {
                Console.WriteLine("IDNumber: " + IDnumber + ": " + fName + " " + lName);
            }
            Console.ReadLine();
        }
    }
}
