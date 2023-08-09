using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuee = true;
            do
            {
                Console.Clear();
                var randomSelection = random();
                Console.WriteLine("Enter Rock, Paper or Scissors: ");
                var input = Console.ReadLine().ToUpper();
                Console.WriteLine($"PC Selection {randomSelection}");
                Console.WriteLine($"Player Selection {input}");
                Console.WriteLine(game(randomSelection, input));
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
            while (continuee);

            Console.WriteLine("I hope you enjoy, bye bye :)");
        }
        static string random()
        {
            Random generator = new Random();
            int number = generator.Next(1, 4);
            switch (number)
            {
                case 1:
                    return "ROCK";
                case 2:
                    return "PAPER";
                case 3:
                    return "SCISSORS";
            }
            return null;
        }
        static string game(string pc, string player)
        {
            if (pc == "ROCK" && player == "ROCK" || pc == "PAPER" && player == "PAPER" || pc == "SCISSSORS" && player == "SCISSSORS")
            {
                return "its a draw!";
            }
            if (pc == "ROCK" && player == "PAPER" || pc == "PAPER" && player == "SCISSORS" || pc == "SCISSORS" && player == "ROCK")
            {
                return "you won!";
            }
            if (pc == "PAPER" && player == "ROCK" || pc == "SCISSORS" && player == "PAPER" || pc == "ROCK" && player == "SCISSORS")
            {
                return "you lose!";
            }
            return null;
        }
    }
}
