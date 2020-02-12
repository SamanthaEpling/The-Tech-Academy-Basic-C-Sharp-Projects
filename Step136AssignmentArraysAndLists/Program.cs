using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //==========Section1: Create a one-dimensional Array of strings.  Ask the user to select an index of the Array and then display the string at that index on the screen.==========

        string[] strArray1 = { "Lionel", "Romani", "Hermione", "Mr. Bubbles", "Fiona", "Rosie" };
        Console.WriteLine("User, please select a number 0 through 5 and we will give you a pet's name!");
        int chosenNum = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = false;

        while (!isGuessed)
        {
            switch (chosenNum)
            {
                case 0:
                    Console.WriteLine("You chose: " + strArray1[0] + "!");
                    isGuessed = true;
                    break;
                case 1:
                    Console.WriteLine("You chose: " + strArray1[1] + "!");
                    isGuessed = true;
                    break;
                case 2:
                    Console.WriteLine("You chose: " + strArray1[2] + "!");
                    isGuessed = true;
                    break;
                case 3:
                    Console.WriteLine("You chose: " + strArray1[3] + "!");
                    isGuessed = true;
                    break;
                case 4:
                    Console.WriteLine("You chose: " + strArray1[4] + "!");
                    isGuessed = true;
                    break;
                case 5:
                    Console.WriteLine("You chose: " + strArray1[5] + "!");
                    isGuessed = true;
                    break;
                default:
                    Console.WriteLine("You did not chose a whole number between 0 and 5.");
                    Console.WriteLine("User, please select a number 0 through 5 and we will give you a pet's name!");
                    chosenNum = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        //==========Section2: Create a one-dimensional Array of integers.  Ask the user to select an index of the Array and then display the integer at that index on the screen.==========

        int[] numArray1 = { 5, 22, 10, 13, 7, 11 };
        Console.WriteLine("\nUser, please select a number 0 through 5 and we will give you a pet's age!");
        int chosenNum2 = Convert.ToInt32(Console.ReadLine());
        bool isGuessed2 = false;

        while (!isGuessed2)
        {
            switch (chosenNum2)
            {
                case 0:
                    Console.WriteLine("You chose " + strArray1[0] + "'s age in years: " + numArray1[0] + "!");
                    isGuessed2 = true;
                    break;
                case 1:
                    Console.WriteLine("You chose " + strArray1[1] + "'s age in years: " + numArray1[1] + "!");
                    isGuessed2 = true;
                    break;
                case 2:
                    Console.WriteLine("You chose " + strArray1[2] + "'s age in years: " + numArray1[2] + "!");
                    isGuessed2 = true;
                    break;
                case 3:
                    Console.WriteLine("You chose " + strArray1[3] + "'s age in years: " + numArray1[3] + "!");
                    isGuessed2 = true;
                    break;
                case 4:
                    Console.WriteLine("You chose " + strArray1[4] + "'s age in years: " + numArray1[4] + "!");
                    isGuessed2 = true;
                    break;
                case 5:
                    Console.WriteLine("You chose " + strArray1[5] + "'s age in years: " + numArray1[5] + "!");
                    isGuessed2 = true;
                    break;
                default:
                    Console.WriteLine("You did not chose a whole number between 0 and 5.");
                    Console.WriteLine("User, please select a number 0 through 5 and we will give you a pet's age!");
                    chosenNum2 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        //==========Section3: Add in a message that displays when the user selects an index that doesn't exist.==========
        // See all sections of code for the creation of cases with a default to deal with other numbers.
        //==========Section4: Create a List of strings.  Ask the user to select an index of the List and then display the content at that index on the screen.==========

        List<string> speciesList = new List<string>();
        speciesList.Add("canine");
        speciesList.Add("Equine");
        speciesList.Add("Feline");
        speciesList.Add("Feline");
        speciesList.Add("Feline");
        speciesList.Add("Feline");

        Console.WriteLine("\nUser, please select a number 0 through 5 and we will give you a pet's species!");
        int chosenNum3 = Convert.ToInt32(Console.ReadLine());
        bool isGuessed3 = false;

        while (!isGuessed3)
        {
            switch (chosenNum3)
            {
                case 0:
                    Console.WriteLine("You chose " + strArray1[0] + "'s species: " + speciesList[0] + ".");
                    isGuessed3 = true;
                    break;
                case 1:
                    Console.WriteLine("You chose " + strArray1[1] + "'s species: " + speciesList[1] + ".");
                    isGuessed3 = true;
                    break;
                case 2:
                    Console.WriteLine("You chose " + strArray1[2] + "'s species: " + speciesList[2] + ".");
                    isGuessed3 = true;
                    break;
                case 3:
                    Console.WriteLine("You chose " + strArray1[3] + "'s species: " + speciesList[3] + ".");
                    isGuessed3 = true;
                    break;
                case 4:
                    Console.WriteLine("You chose " + strArray1[4] + "'s age in years: " + speciesList[4] + ".");
                    isGuessed3 = true;
                    break;
                case 5:
                    Console.WriteLine("You chose " + strArray1[5] + "'s age in years: " + speciesList[5] + ".");
                    isGuessed3 = true;
                    break;
                default:
                    Console.WriteLine("You did not chose a whole number between 0 and 5.");
                    Console.WriteLine("User, please select a number 0 through 5 and we will give you a pet's species!");
                    chosenNum3 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        Console.ReadLine();
    }
}