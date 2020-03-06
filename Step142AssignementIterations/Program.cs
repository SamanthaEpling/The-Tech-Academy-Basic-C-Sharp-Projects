using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    //=====Section1: Array of strings with a loop with user input======

    //{
    //    Console.WriteLine("Type a sentence for every single one of the pets: ");
    //    string sentence = Console.ReadLine();
    //    string[] names = { "Lionel", "Romani", "Rosie", "Fiona" };

    //    for (int i = 0; i < names.Length; i++)
    //    {
    //        Console.WriteLine(names[i] + sentence);
    //    }
    //    Console.ReadLine();
    //}
    //=====Section2: to create an infinite loop:=====

    //{
    //    string[] names = { "Lionel", "Romani", "Rosie", "Fiona" };
    //    int i = 0;
    //    do
    //    {
    //        Console.WriteLine(names[i] + " is a great pet!");
    //    }
    //    while (i < 5);
    //    Console.ReadLine();
    //}

    //=====Section 3: to fix an infinite loop:======

    //{
    //    string[] names = { "Lionel", "Romani", "Rosie", "Fiona" };
    //    int i = 0;
    //    do
    //    {
    //        Console.WriteLine(names[i] + " is a great pet!");
    //        i++;
    //    }
    //    while (i < 4);
    //    Console.ReadLine();
    //}

    //=====Section 4: loop with < comparison:======

    //{
    //    List<int> petAges = new List<int>() { 5, 22, 10, 7 };

    //    foreach (int age in petAges)
    //    {
    //        if (age < 7)
    //        {
    //            Console.WriteLine(age + ": This pet's age would eat an adult diet.");
    //        }
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 5: loop with <= comparison:======

    // With respect, I know the assignment asks us to use a <= operator, but this fits better with my data list, I hope that's ok.
    //{
    //    List<int> petAges = new List<int>() { 5, 22, 10, 7 };

    //    foreach (int age in petAges)
    //    {
    //        if (age >= 7)
    //        {
    //            Console.WriteLine(age + ": This pet's age would eat a mature (senior) diet.");
    //        }
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 6: List of strings with user search for index of array:======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona" };

    //    Console.WriteLine("Please type a pet name to see who is on the list: ");
    //    string chosenName = Console.ReadLine();

    //    for (int i = 0; i < Pets.Count; i++)
    //    {
    //        if (Pets[i] == chosenName)
    //        {
    //            Console.WriteLine("Congratulations! " + chosenName + " was on the pet list at index: " + i);
    //        }
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 7: Adding code if the user was ineffective ;) :======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona" };

    //    Console.WriteLine("Please type a pet name to see who is on the list: ");
    //    string chosenName = Console.ReadLine();
    //    bool isPresent = false;

    //    foreach (string pet in Pets)
    //    {
    //        if (pet == chosenName)
    //        {
    //            Console.WriteLine("Congratulations! " + chosenName + " was on the pet list at index: " + Pets.IndexOf(pet));
    //            isPresent = true;
    //        }
    //    }
    //    if (!isPresent)
    //    {
    //        Console.WriteLine("Oh darn, that name is not on our list.");
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 8: Adding code to stop code once user was effective:======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona" };

    //    Console.WriteLine("Please type a pet name to see who is on the list: ");
    //    string chosenName = Console.ReadLine();
    //    bool isPresent = false;

    //    foreach (string pet in Pets)
    //    {
    //        if (pet == chosenName)
    //        {
    //            Console.WriteLine("Congratulations! " + chosenName + " was on the pet list at index: " + Pets.IndexOf(pet));
    //            isPresent = true;
    //            break;
    //        }
    //    }
    //    if (!isPresent)
    //    {
    //        Console.WriteLine("Oh darn, that name is not on our list. Please try again.");
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 9: Selecting identical strings through iterations:======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona", "Love Bug", "Mister", "Romani" };
    //    Console.WriteLine("Please type a pet name to see who is on the list: ");
    //    string chosenName = Console.ReadLine();
    //    for (int i = 0; i < Pets.Count; i++)
    //    {
    //        if (Pets[i] == chosenName)
    //        {
    //            Console.WriteLine("Congratulations! " + chosenName + " was on the pet list at index(es): " + i);
    //            isPresent = true;
    //        }
    //    }
    //    Console.ReadLine();
    //}

    //=====Section 10: Adding code to stop code once user was effective:======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona", "Love Bug", "Mister", "Romani" };
    //    bool isPresent = false;
    //    do
    //    {
    //        Console.WriteLine("Please type a pet name to see who is on the list: ");
    //        string chosenName = Console.ReadLine();

    //        for (int i = 0; i < Pets.Count; i++)
    //        {
    //            if (Pets[i] == chosenName)
    //            {
    //                Console.WriteLine("Congratulations! " + chosenName + " was on the pet list at index(es): " + i);
    //                isPresent = true;
    //            }
    //            else if(Pets[i] != chosenName)
    //            {
    //                 Console.WriteLine("Your name " + chosenName + " does not appear at index: " + i);
    //            }
    //        }            
    //        Console.ReadLine();
    //    }while (isPresent == false);  
    //}


    //=====Section 11: Selecting and indicating identical strings through iterations:======

    //{
    //    List<string> Pets = new List<string>() { "Lionel", "Romani", "Rosie", "Fiona", "Love Bug", "Mister", "Romani", "Fiona" };
    //    List<string> ReplicatePets = new List<string>();

    //    foreach (string pet in Pets)
    //    {
    //        if (ReplicatePets.Contains(pet))
    //        {
    //            Console.WriteLine(pet + " has now already appeared on the list multiple times!");
    //        }
    //        else
    //        {
    //            ReplicatePets.Add(pet);
    //            Console.WriteLine(pet + " has been listed at least this once.");
    //        }
    //    }
    //    Console.ReadLine();
    //}

}