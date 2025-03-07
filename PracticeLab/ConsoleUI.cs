namespace PracticeLab
{
    public class ConsoleUI
    {
        FileSaver fileSaver;

        public ConsoleUI()
        {
            fileSaver = new FileSaver("SpanishVocab.data.txt");
        }

        public void Show()
        {
            string mode = AskForInput("Please Select a user (Mateo or Other): ");

            if (mode == "Mateo")
            {
                string command;

                do
                {
                    string stopName = AskForInput("Enter new word: ");

                    int boarded = int.Parse(AskForInput("Enter Comprehension Score: "));

                    fileSaver.AppendLine(stopName + ";" + boarded);

                    command = AskForInput("Enter command (end or continue): ");

                } while (command != "end");
            }
        }

        public static string AskForInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}