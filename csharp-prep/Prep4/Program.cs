using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();
        
        int myNumber = -1;
        while (myNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            
            string userResponse = Console.ReadLine();
            myNumber = int.Parse(userResponse);
            
            // If the number is not 0, add it to the list
            if (myNumber != 0)
            {
                numbersList.Add(myNumber);
            }
        }

        // Calculate the sum
        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        float average = ((float)sum) / numbersList.Count; // cast sum to float to avoid integer division
        Console.WriteLine($"The average is: {average}");

        // Find the highest number
        
        int highest = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > highest)
            {
                // Check if greater than the current highest number
                highest = number;
            }
        }

        Console.WriteLine($"The largest number is: {highest}");
    }
}