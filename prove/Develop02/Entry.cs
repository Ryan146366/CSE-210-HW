using System.IO;

public class Entry
{

    public void DisplayEntries(){
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ryand\OneDrive\Desktop\CSE 210\CSE-210-HW\prove\Develop02\Journal.txt");

        // Display the file contents by using a foreach loop.
        System.Console.WriteLine("Contents of journal.txt = ");
        foreach (string line in lines)
        {
            Console.WriteLine("\t" + line);
        }
    
    }
}