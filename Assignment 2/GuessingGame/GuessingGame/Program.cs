using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {
            string choice;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                bool userWon = false;
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("guess:");
                    int guess = int.Parse(Console.ReadLine());
                    if (guess == randomNumber)
                    {
                        Console.WriteLine("Hooray! You won.");
                        userWon = true;
                        break;
                    }
                    else if (guess > randomNumber)
                        Console.WriteLine("Your Guess is greater");
                    else
                        Console.WriteLine("Your Guess is smaller");
                }
                if (!userWon)
                {
                    Console.WriteLine("Oh no! You Lost.");
                    Console.WriteLine($"Correct number is:{randomNumber}");
                }
                Console.Write("Replay (Y/N)?");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
           
        }
    }
}
