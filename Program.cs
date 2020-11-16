using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = new Random().Next(1, 101);
            Console.WriteLine($"HINT: the number is {secretNum} ");
            int userTries = 0;
            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());

            while (guess != secretNum && userTries < 3)
            {
                Console.WriteLine("Incorrect! Guess again...");
                if (guess < secretNum)
                {
                    Console.WriteLine("Too small");
                }
                else
                {
                    Console.WriteLine("Too big");

                }
                userTries++;
                Console.WriteLine($"{userTries} out of 4. Try again");
                Console.WriteLine("");
                guess = int.Parse(Console.ReadLine());
            }

            if (userTries < 3 || guess == secretNum)
            {
                Console.WriteLine($"Hurray! The secret number is {secretNum}!");
            }
            else
            {
                userTries++;
                Console.WriteLine($"{userTries} out of 4. You ran out of tries!");
            }
        }
    }
}
