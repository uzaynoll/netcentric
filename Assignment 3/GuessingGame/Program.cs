using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Lets's start the gaame aye !!!");
           do
           {
                int randomNumber=generateRandom();
                Console.WriteLine($"Correct number is:{randomNumber}");
                guessNumber(randomNumber);
           }while(replay()=="y");
        }
        private static int generateRandom()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
        private static string replay()
        {
            Console.Write("You wanna go again(Y/N) ?: ");
            return Console.ReadLine().ToUpper();  
        }
        private static void guessNumber(int randomNumber)
        {
            bool userWon=false;
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
                Finish(userWon,randomNumber);
        }
        private static void Finish(bool userWon,int randomNumber)
        {
            if (!userWon)
                {
                    Console.WriteLine("Oh no! You Lost.");
                    Console.WriteLine($"Correct number is:{randomNumber}");
                }
        }
    }
}
