using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {   bool playAgain = true;
        while (playAgain)
        
        {
            // Generate a random number
        
            Random number = new Random();
            int magicNumber = number.Next(1, 101); // Generate random numbers from 1 to 100
            int userGuess = 0;
            int guessCount =0;
            Console.Write("What is the magic number? ");
            Console.WriteLine(magicNumber);

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");

                }
                else if (magicNumber < userGuess)
                {
                    Console.WriteLine("Lower");

                }
                else
                {
                    Console.WriteLine("You gussed it!");
                    Console.WriteLine($"You attempts are: {guessCount}");
                }
            }   
            Console.WriteLine("Do you want to play again? ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");

        
        }   
           

    }
}