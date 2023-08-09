using System;

namespace BmiCliVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            static void invalidCommand()
            {
                Console.WriteLine("Invalid command:(\nUse --helps switch to show help.");
            }
            static void version()
            {
                Console.WriteLine("Current verson is : 1.0");
            }
            static void helps()
            {
                Console.WriteLine("use these switch to run program :\n--height\t \tYour height (centimeters)\n--weight\t \tYour weight (kilograms)\n--version\t \tshow current version\n--helps\t \t \tshow command list");
            }
            static void bmi(double weight, double height)
            {
                var bmi = Math.Round(weight / Math.Pow(height / 100, 2));
                Console.WriteLine($"Your Number BMI is : {bmi}");
                if (bmi <= 18.4)
                {
                    Console.WriteLine("Underweight!");
                }
                else if (bmi >= 18.5 && bmi <= 24.9)
                {
                    Console.WriteLine("Normal");
                }
                else if (bmi >= 25 && bmi <= 39.9)
                {
                    Console.WriteLine("Overweight");
                }
                else if (bmi >= 40)
                {
                    Console.WriteLine("Obese");
                }
            }
            if (args.Length == 0)
            {
                invalidCommand();
                Environment.Exit(0);
            }
            if (args[0] == "bmi")
            {
                if (args[1] == "--helps")
                {
                    helps();
                }
                else if (args[1] == "--version")
                {
                    version();
                }
                else if (args[1] == "--height" && args[3] == "--weight")
                {
                    var height = Convert.ToDouble(args[2]);
                    var weight = Convert.ToDouble(args[4]);
                    bmi(weight, height);
                }
                else if (args[1] == "--weight" && args[3] == "--height")
                {
                    var height = Convert.ToDouble(args[4]);
                    var weight = Convert.ToDouble(args[2]);
                    bmi(weight, height);
                }
                else if (args[1] != "--weight" || args[1] != "--height" || args[3] != "--height" || args[3] != "--weight")
                {
                    invalidCommand();
                }
                else
                {
                    invalidCommand();
                }
            }
            else
            {
                invalidCommand();
            }
        }
    }
}
