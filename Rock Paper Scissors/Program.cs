using System;
using Microsoft.VisualBasic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = false;
            do
            {
                var botSelect = Bot();
                var playerSelect = Player();

                Console.WriteLine($"Bot pick : {botSelect}");
                Compare(botSelect, playerSelect);

                Console.WriteLine("Do you like do it again?(Y/N) : ");
                var again = Console.ReadLine().ToUpper();

                loop = again != "Y";
            } while (!loop);

            Console.WriteLine("Thanks for playin ^-^");
        }
        static string Bot()
        {
            Random rnd = new Random();

            string[] bot = ["rock", "paper", "scissors"];
            int rndNumber = rnd.Next(0, 3);
            string rndSelect = bot[rndNumber];

            return rndSelect;
        }
        static string Player()
        {
            Console.WriteLine("Enter rock, paper, scissors :");
            var playerSelect = Console.ReadLine().ToLower();

            return playerSelect;
        }
        static void Compare(string bot, string player)
        {
            if (bot == player)
            {
                Console.WriteLine("its a draw!");
            }
            else if (bot == "rock" && player == "paper" || bot == "paper" && player == "scissors" || bot == "scissors" && player == "rock")
            {
                Console.WriteLine("you won!");
            }
            else if (bot == "paper" && player == "rock" || bot == "scissors" && player == "paper" || bot == "rock" && player == "scissors")
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("Something wrong!");
            }
        }

    }
}
