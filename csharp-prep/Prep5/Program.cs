using System;

class Program
{
   
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;

     }
    static int PromptUserNumber()
     {
        Console.WriteLine("Please enter your favorite number");
        int fav_number = Convert.ToInt32(Console.ReadLine());

        return fav_number;
    }
    static int SquareNumber(int fav_number)
    {
        int square = fav_number * fav_number;

        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.Write($"{name}, The square of your number is {square}");
     }
    static void Main(string[] args)
    {
     DisplayWelcome();
     string username = PromptUserName();
     int number = PromptUserNumber();
     int square = SquareNumber(number);
     DisplayResult(username, square);  
    }
}