using System;

namespace TV_Control_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string theAnswer;
            var like = true;
            var channel = 0;
            do
            {
                Console.Clear();
                Console.WriteLine($"Channel ({++channel})\nDo you enjoy watching this channel?(Yes/No)--> ");
                theAnswer = Console.ReadLine().ToLower();
                if (theAnswer == "yes")
                {
                    Console.WriteLine($"Enjoy watching Channel {channel} :)");
                    like = true;
                }
                else
                {
                    like = false;
                };
            }
            while (!like);
        }
    }
}
