using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        // Ask to generate or to input a magic number
        Console.Write("Do you want to input a magic number? (y/n) If no, a random magic number will be generated. ");
        string response = Console.ReadLine();
        if (response == "y")
        {
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
        }
        else
        {
            Random randomGenerator = new Random();
            magicNumber = randomGenerator.Next(1, 101);
        }

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } 
    }
}