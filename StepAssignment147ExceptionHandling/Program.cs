using System;
using System.Collections.Generic;


namespace StepAssignment147ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============Section 1===============//

            //List<int> petAges = new List<int>() { 115, 76, 10, 84, 123, 157 };
            //Console.WriteLine("Give a number to divide each number on the list by.");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < petAges.Count; i++)
            //{
            //    int numberThree = petAges[i] / numberTwo;
            //    Console.WriteLine(petAges[i] + " divided by " + numberTwo + " equals " + numberThree + ".");
            //}
            //Console.ReadLine();

            //===============Section 2===============//

            //List<int> petAges = new List<int>() { 115, 76, 10, 84, 123, 157 };
            //Console.WriteLine("Give a number to divide each number on the list by.");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            ////when attempting to enter in "six", or 4.7: this was the following error: System.FormatException: 'Input string was not in a correct format.'

            //for (int i = 0; i < petAges.Count; i++)
            //{
            //    int numberThree = petAges[i] / numberTwo;
            //    Console.WriteLine(petAges[i] + " divided by " + numberTwo + " equals " + numberThree + ".");
            //}
            //Console.ReadLine();

            //===============Section 3===============//

            //List<int> petAges = new List<int>() { 115, 76, 10, 84, 123, 157 };
            //Console.WriteLine("Give a number to divide each number on the list by.");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < petAges.Count; i++)
            //{
            //    int numberThree = petAges[i] / numberTwo;
            //    //when attempting to enter in 0: this was the following error: System.DivideByZeroException: 'Attempted to divide by zero.'
            //    Console.WriteLine(petAges[i] + " divided by " + numberTwo + " equals " + numberThree + ".");
            //}
            //Console.ReadLine();

            //===============Section 4===============//

            //See Section 2...

            //===============Section 5===============//

            //List<int> petAges = new List<int>() { 115, 76, 10, 84, 123, 157 };

            //try
            //{

            //    Console.WriteLine("Give a number to divide each number on the list by.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());

            //    for (int i = 0; i < petAges.Count; i++)
            //    {
            //        int numberThree = petAges[i] / numberTwo;
            //        Console.WriteLine(petAges[i] + " divided by " + numberTwo + " equals " + numberThree + ".");
            //    }
            //    Console.ReadLine();
            //}
            //catch (System.FormatException)
            //{
            //    Console.WriteLine("You tried putting in a string or not a whole integer, didn't you!");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You tried dividing by zero didn't you!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}

            //=============== END ASSIGNMENT ===============//
        }
    }
}
