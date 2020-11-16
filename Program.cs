using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 43;
            int userTries = 1;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());

            while (guess != secretNum && userTries < 4)
            {
                Console.WriteLine("Guess again...");
                guess = int.Parse(Console.ReadLine());
                userTries++;
            }

            if (userTries == 4)
            {
                Console.WriteLine("failure");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}
