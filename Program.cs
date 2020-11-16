using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNum = new Random().Next(1, 101);
            int userTries = 0;
            int difficultyLevel = 0;


            while (difficultyLevel == 0)
            {
                Console.WriteLine("Select a difficulty");
                Console.WriteLine("1) Easy - eight guesses");
                Console.WriteLine("2) Medium - six guesses");
                Console.WriteLine("3) Hard - four guesses");


                difficultyLevel = int.Parse(Console.ReadLine());

                switch (difficultyLevel)
                {
                    case 1:
                        userTries = 8;
                        break;
                    case 2:
                        userTries = 6;
                        break;
                    case 3:
                        userTries = 4;
                        break;

                    default:
                        userTries = 8;
                        // Console.WriteLine("must select 1, 2, or 3.");
                        break;
                }
            }

            Console.WriteLine("Guess the secret number...");
            int guess = int.Parse(Console.ReadLine());

            Console.WriteLine($"HINT: the number is {secretNum} ");

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
                Console.WriteLine($"You have {userTries} tries left. Try again");
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
