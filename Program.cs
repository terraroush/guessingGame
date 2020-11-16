using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 43;
            int userTries = 0;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());

            while (guess != secretNum && userTries < 3)
            {
                Console.WriteLine("Incorrect! Guess again...");
                // Console.WriteLine("");
                userTries++;
                Console.WriteLine($"You've tried {userTries} times.");
                Console.WriteLine("");
                guess = int.Parse(Console.ReadLine());
            }

            if (userTries < 3 || guess == secretNum)
            {
                Console.WriteLine($"Hurray! The secret number is {secretNum}!");
            }
            else
            {
                Console.WriteLine("You didn't guess in the right number of tries!");
            }
        }
    }
}
