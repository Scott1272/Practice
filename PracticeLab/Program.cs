namespace PracticeLab;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        string input;

        Console.WriteLine("Enter names (type 'done' to finish):");
        while ((input = Console.ReadLine()) != "done")
        {
            names.Add(input);
        }

        Console.WriteLine("Select a name:");
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {names[i]}");
        }

        int selectedIndex = int.Parse(Console.ReadLine()) - 1;
        string selectedName = names[selectedIndex];

        Console.WriteLine($"Hello, {selectedName}! Please choose an option:");
        Console.WriteLine("1. Add A new word");
        Console.WriteLine("2. Update a comprehension score");
        Console.WriteLine("3. Generate or View Report");
        Console.WriteLine("4. End");

        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                // Code to add a new word
                break;
            case 2:
                // Code to update comprehension score
                break;
            case 3:
                // Code to generate or view report
                break;
            case 4:
                Console.WriteLine("Ending the application.");
                break;
            default:
                Console.WriteLine("Invalid option selected.");
                break;
        }
    }
}