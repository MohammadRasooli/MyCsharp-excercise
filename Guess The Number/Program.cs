using System;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double guess = 0;
            bool continuee = true;
            while (continuee)
            {
                Console.Clear();
                Random generator = new Random();
                int number = generator.Next(1, 101);
                bool repetition = true;
                int round = 0;
                do
                {
                    Console.WriteLine("Guess a number between 1 and 100: ");
                    guess = Convert.ToDouble(Console.ReadLine());
                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is to high!");
                        round++;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is to low!");
                        round++;
                    }
                    else
                    {
                        repetition = false;
                    }
                }
                while (repetition);

                Console.Clear();
                Console.WriteLine($"Congratulations, you won after {round} rounds. \nThe number was {number}!");
                Console.WriteLine("Do you want to play again?(Y/N) ");
                var again = Console.ReadLine().ToLower();
                while (again != "y" && again != "n")
                {
                    Console.WriteLine("An error has occurred. Please only use (y or n).");
                    again = Console.ReadLine().ToLower();
                }
                if (again == "n")
                {
                    continuee = false;
                }
            }
            Console.WriteLine("I hope you enjoy, bye bye :)");
        }
    }
}
