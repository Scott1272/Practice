namespace PracticeLab;

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please select name (Mateo or Other): ");
        string mode = Console.ReadLine();

        if (mode.Equals("Mateo", StringComparison.OrdinalIgnoreCase))
        {
            string command;

            do
            {
                Console.Write("Enter New Spanish Word: ");
                string newWord = Console.ReadLine();

                Console.Write("Enter Comprehension Rating: ");
                int comprehensionScore = int.Parse(Console.ReadLine());

                string dateEntered = DateTime.Now.ToString("yyyy-MM-dd");
                File.AppendAllText("SpanishVocab.data.txt", $"{newWord}:{comprehensionScore}:{dateEntered}{Environment.NewLine}");

                Console.Write("Enter command (end or continue): ");
                command = Console.ReadLine();

            } while (!command.Equals("end", StringComparison.OrdinalIgnoreCase));
        }
        else
        {
            Console.WriteLine("Sorry, this is app only for Mateo. If you would like to use please contact us."); 
        }
    }
}