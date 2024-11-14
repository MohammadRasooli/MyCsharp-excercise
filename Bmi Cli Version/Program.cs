using System;
using Microsoft.VisualBasic;


namespace BmiCliVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation(args, out double height, out double weight);
            BmiTest(weight, height);
        }

        static void Error()
        {
            Console.WriteLine("Invalid command:(\nUse --helps switch to show help.");
            Environment.Exit(0);
        }
        static void Validation(string[] args, out double height, out double weight)
        {
            if (args.Length <= 1 || args[0] != "bmi")
            {
                Error();
            }

            height = 0;
            weight = 0;

            if (args.Length == 5)
            {
                var firstSwitch = args[1];
                var firstArg = args[2];

                var seccondSwitch = args[3];
                var seccondArg = args[4];

                if (firstSwitch == "--weight" && seccondSwitch == "--height")
                {
                    weight = Convert.ToDouble(firstArg);
                    height = Convert.ToDouble(seccondArg);
                }
                else if (firstSwitch == "--height" && seccondSwitch == "--weight")
                {
                    height = Convert.ToDouble(firstArg);
                    weight = Convert.ToDouble(seccondArg);
                }
                else
                {
                    Error();
                }
            }
            else
            {
                if (args.Length >= 3)
                {
                    Error();
                }
                else if (args[1] == "--helps")
                {
                    Console.WriteLine("use these switch to run program :\n--height\t \tYour height (centimeters)\n--weight\t \tYour weight (kilograms)\n--version\t \tshow current version\n--helps\t \t \tshow command list");
                    Environment.Exit(0);
                }
                else if (args[1] == "--version")
                {
                    Console.WriteLine("Current verson is : 1.0");
                    Environment.Exit(0);
                }
                else
                {
                    Error();
                }
            }
        }
        static void BmiTest(double weight, double height)
        {
            if (weight == 0 && height == 0)
            {
                Error();
            }
            height = height / 100;
            double bmiFormula = Math.Round(weight / (height * height));

            Console.WriteLine($"Your bmi number is : {bmiFormula}");

            if (bmiFormula < 18.5)
            {
                Console.WriteLine("Underwight");
            }
            else if (bmiFormula >= 18.5 && bmiFormula <= 24.9)
            {
                Console.WriteLine("Normal weight");
            }
            else if (bmiFormula >= 25 && bmiFormula <= 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obesity");
            }

        }

    }
}
