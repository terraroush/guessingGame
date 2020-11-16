using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = 43;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());
            while (secretNum != guess)
            {
                Console.WriteLine("Guess again...");
                guess = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("You got it correct");
        }
    }
}
