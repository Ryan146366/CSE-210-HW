using System;

public class Program
{
    public static void Main(string[] args)
    {
        int choice = 0;
        Journal journal = new Journal();
        while (choice != 5){
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                string journalPrompt = Journal.dailyPrompt;
                Console.WriteLine($"Prompt: {journalPrompt}");
                journal.Write();
            }
            else if (choice == 2)
            {
                Entry entry = new Entry();
                entry.DisplayEntries();
            }
            else if (choice == 3)
            {
                Console.Write("What file do you want to load? ");
                journal.filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                Console.Write("What file do you want to save to? ");
                journal.filename = Console.ReadLine();
                journal.SaveFile();
            }
            }
        }
        

    
}