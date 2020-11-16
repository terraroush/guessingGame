using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = new Random().Next(1, 101);
            Console.WriteLine($"HINT: the number is {secretNum} ");
            int userTries = 4;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());

            while (guess != secretNum && userTries != 1)
            {
                Console.WriteLine("Incorrect! Guess again...");
                if (guess < secretNum)
                {
                    Console.WriteLine("Too LOW");
                }
                else
                {
                    Console.WriteLine("Too HIGH");

                }
                userTries--;
                Console.WriteLine($"You have {userTries} out of 4 tries left. Try again");
                Console.WriteLine("");
                guess = int.Parse(Console.ReadLine());
            }

            if (userTries != 1 || guess == secretNum)
            {
                Console.WriteLine($"Hurray! The secret number is {secretNum}!");
            }
            else
            {
                Console.WriteLine($"You ran out of tries!");
            }
        }
    }
}
