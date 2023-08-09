using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            string symbol;
            bool again = false;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("------------------\nCalculator Program\n------------------");
                    Console.Write("Enter number 1 : ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter number 2 : ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Options:");
                    Console.WriteLine("\t+ : Add\n\t- : Subtract\n\t* : Multiply\n\t/ : Divide");
                    Console.Write("Enter an Option : ");
                    symbol = Console.ReadLine();
                    if (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/")
                    {
                        Console.WriteLine("This is not in the options!");
                        Console.Write("Would you like to continue?(y/n) : ");
                        symbol = Console.ReadLine().ToLower();
                        while (symbol != "y" && symbol != "n")
                        {
                            Console.WriteLine("Please only use (y or n)");
                            symbol = Console.ReadLine().ToLower();
                        }
                    }
                    switch (symbol)
                    {
                        case "+":
                            add(n1, n2);
                            break;
                        case "-":
                            subtract(n1, n2);
                            break;
                        case "*":
                            multiply(n1, n2);
                            break;
                        case "/":
                            divide(n1, n2);
                            break;
                        case "y":
                            again = true;
                            break;
                        case "n":
                            again = false;
                            Console.WriteLine("Bye...");
                            break;
                    }
                    if (symbol != "y" && symbol != "n")
                    {
                        Console.Write("Would you like to continue?(y/n) : ");
                        symbol = Console.ReadLine().ToLower();
                        while (symbol != "y" && symbol != "n")
                        {
                            Console.WriteLine("Please only use (y or n)");
                            symbol = Console.ReadLine().ToLower();
                        }
                        switch (symbol)
                        {
                            case "y":
                                again = true;
                                break;
                            case "n":
                                again = false;
                                Console.WriteLine("Bye...");
                                break;
                        }
                    }
                }
                while (again);
            }
            catch
            {
                Console.WriteLine("An error has occurred!");
            }
        }
        public static void add(double n1, double n2)
        {
            var Result = n1 + n2;
            Console.WriteLine($"Your result: {n1} + {n2} = " + Result);
        }
        public static void subtract(double n1, double n2)
        {
            var Result = n1 - n2;
            Console.WriteLine($"Your result: {n1} - {n2} = " + Result);
        }
        public static void multiply(double n1, double n2)
        {
            var Result = n1 * n2;
            Console.WriteLine($"Your result: {n1} * {n2} = " + Result);
        }
        public static void divide(double n1, double n2)
        {
            var Result = n1 / n2;
            Console.WriteLine($"Your result: {n1} / {n2} = " + Result);
        }
    }
}
