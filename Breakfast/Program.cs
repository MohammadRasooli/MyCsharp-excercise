using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Breakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            coffee();
            var eggs = eggCooking(2);
            var bacons = baconCooking(3);
            var toastAndJam = toastingAndJam(1);
            Console.WriteLine("Heat the pan...");
            var Breakfast = new List<Task> { eggs, bacons, toastAndJam };
            while (Breakfast.Count > 0)
            {
                Task Finished = await Task.WhenAny(Breakfast);
                if(Finished == eggs)
                {
                    Console.WriteLine("eggs is ready!");
                }
                else if(Finished == bacons)
                {
                    Console.WriteLine("bacon is ready!");
                }
                else if (Finished == toastAndJam)
                {
                    juice();
                }
                Breakfast.Remove(Finished);
            }
            Console.WriteLine("Breakfast is ready!");

        }
        static void coffee()
        {
            Console.WriteLine($"Pouring coffee");
            Console.WriteLine($"coffee is ready.");
        }
        static async Task eggCooking(int number)
        {
            Console.WriteLine($"Take out {number} eggs.");
            await Task.Delay(300);
            Console.WriteLine("Fry the eggs...");
            await Task.Delay(2000);

        }
        static async Task baconCooking(int number)
        {
            Console.WriteLine($"Take out {number} bacons.");
            Console.WriteLine("Fry the bacon...");
            await Task.Delay(1400);

        }
        static async Task toastingAndJam(int number)
        {
            Console.WriteLine($"Start toasting bread.");
            await Task.Delay(1700);
            Console.WriteLine("bread is ready.");
            Console.WriteLine("putting jam on toast");
            await Task.Delay(400);
        }
        static void juice()
        {
            Console.WriteLine("pouring orange juice...");
            Console.WriteLine("Juice is ready.");
        }
    }
}
