using System;

class Program
{
    static void Main(string[] args)
    {
        int user_number = -1;
        int sum = 0;
        int max = 0;



        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (user_number != 0)
        {
            Console.Write("Enter Number: ");
            user_number = Convert.ToInt32(Console.ReadLine());
            numbers.Add(user_number);


        }
        foreach (int number in numbers)
        {
            sum += number;
            if (number > max)
            {
                max = number;
            }
            

        }
        int size = numbers.Count;
        float average = sum / size;
        
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The Largest Number is {max}");



    }


}