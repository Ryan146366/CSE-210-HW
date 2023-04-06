using System;

public class ListingActivity : Activity
{
    private int numItems;
    private string[] _promptList = new String[5] {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void GeneratePrompt()    // generates a random prompt from _promptlist
    {
        Random random = new Random();
        Console.WriteLine(_promptList[random.Next(_promptList.Length)]);

        for(int i = 0; i < 10; i++)        // waits 10 secods before prompting the user 
        {
            Thread.Sleep(1000);
            Console.WriteLine(10-i);
        }
        Console.WriteLine("Please list everything that came to mind: ");
    }

    public void CountUserItems()        // generates a count for the number of items listed and stores it in numItems
    {
        Console.ReadLine();
        numItems += 1;
    }

    public void DisplayNumItems()       // displays the number of items the user entered using the count generated in numIt
    {
        Console.WriteLine($"Number of Items Listed: {numItems}");
    }
}