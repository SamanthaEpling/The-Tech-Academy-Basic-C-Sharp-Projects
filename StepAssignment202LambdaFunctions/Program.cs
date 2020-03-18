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


            List<Employee> empList = new List<Employee>();
            List<Employee> selectedEmployee = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.fName = "Joe";
            employee1.lName = "Smith";
            employee1.IDnumber = 1;
            empList.Add(employee1);
            Employee employee2 = new Employee();
            employee2.fName = "Joe";
            employee2.lName = "Brown";
            employee2.IDnumber = 2;
            empList.Add(employee2);
            Employee employee3 = new Employee();
            employee3.fName = "Leo";
            employee3.lName = "NinjaTurtle";
            employee3.IDnumber = 3;
            empList.Add(employee3);
            Employee employee4 = new Employee();
            employee4.fName = "Don";
            employee4.lName = "NinjaTurtle";
            employee4.IDnumber = 4;
            empList.Add(employee4);
            Employee employee5 = new Employee();
            employee5.fName = "Raf";
            employee5.lName = "NinjaTurtle";
            employee5.IDnumber = 5;
            empList.Add(employee5);
            Employee employee6 = new Employee();
            employee6.fName = "Mike";
            employee6.lName = "NinjaTurtle";
            employee6.IDnumber = 6;
            empList.Add(employee6);
            Employee employee7 = new Employee();
            employee7.fName = "Milo";
            employee7.lName = "Adventurer";
            employee7.IDnumber = 7;
            empList.Add(employee7);
            Employee employee8 = new Employee();
            employee8.fName = "Otis";
            employee8.lName = "Adventurer";
            employee8.IDnumber = 8;
            empList.Add(employee8);
            Employee employee9 = new Employee();
            employee9.fName = "Trigger";
            employee9.lName = "Rogers";
            employee9.IDnumber = 9;
            empList.Add(employee9);
            Employee employee10 = new Employee();
            employee10.fName = "Dug";
            employee10.lName = "Up";
            employee10.IDnumber = 10;
            empList.Add(employee10);




            // foreach loop for section 2...

            //foreach (Employee employee in empList)
            //{
            //    if (employee.fName == "Joe")
            //    {
            //        selectedEmployee.Add(employee);                   
            //    }
            //}
            //Console.WriteLine("Information for all employees named Joe: ");
            //foreach (Employee employee in selectedEmployee)
            //{
            //    Console.WriteLine("ID: " + employee.IDnumber + ": " + employee.lName + ", " + employee.fName);
            //}
            //Console.ReadLine();



            // ======================= Sections 3: using the lambda expression ============================


            //selectedEmployee = empList.Where(x => x.fName == "Joe").ToList();
            //Console.WriteLine("Information for all employees named Joe: ");
            //foreach (Employee employee in selectedEmployee)
            //{
            //    Console.WriteLine("ID: " + employee.IDnumber + " " + employee.lName + ", " + employee.fName);
            //}
            //Console.ReadLine();


            // ======================= Sections 4: using the lambda expression ============================

            //selectedEmployee = empList.Where(x => x.IDnumber > 5).ToList();
            //Console.WriteLine("All employees that have an ID number greater than 5: ");
            //foreach (Employee employee in selectedEmployee)
            //{
            //    Console.WriteLine("ID: " + employee.IDnumber + " " + employee.fName + " " + employee.lName);
            //}
            //Console.ReadLine();
        }
    }
}
