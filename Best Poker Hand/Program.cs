using System;
using System.Linq;
namespace BestPokerHand
{
    class Program
    {
        static void Main(string[] args)
        {
            var ranks = new int[] { 1, 2, 3, 4, 5 };
            var suits = new char[] { 'e', 'a', 'a', 'a', 'a' };

            Console.WriteLine(bestHandPoker(ranks, suits));
        }
        static string bestHandPoker(int[] ranks, char[] suits)
        {
            if (suits.Count(a => a == suits[0]) == 5)
                return $"ranks =" + string.Join(",", ranks) + $"\nsuits =" + string.Join(",", suits) + "\nBest Hand ----> Flush";

            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks.Count(a => a == ranks[i]) >= 3)
                    return $"ranks =" + string.Join(",", ranks) + $"\nsuits =" + string.Join(",", suits) + "\nBest Hand ----> Three of a Kind";
            }

            for (int i = 0; i < ranks.Length; i++)
            {
                if (ranks.Count(a => a == ranks[i]) == 2)
                    return $"ranks =" + string.Join(",", ranks) + $"\nsuits =" + string.Join(",", suits) + "\nBest Hand ----> Pair";
            }

            return $"ranks =" + string.Join(",", ranks) + $"\nsuits =" + string.Join(",", suits) + "\nBest Hand ----> High Card";
        }
    }
}