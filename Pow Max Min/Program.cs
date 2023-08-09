using System;

namespace PowMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to get power.");
            Console.WriteLine("First number : ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number: ");
            var y = Convert.ToDouble(Console.ReadLine());
            var power = pow(x, y);
            Console.WriteLine($"The power of this number is {power}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter five numbers to check the highest and lowest :");
            var numbers = new double[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            var maximum = max(numbers);
            var minimum = min(numbers);
            Console.WriteLine($"maximum number : {maximum}\nminimum number : {minimum}");

        }
        static double pow(double x, double y)
        {
            double power = x;
            if (x == 0)
            {
                return 0;
            }
            if (y == 0)
            {
                return 1;
            }
            for (int i = 1; i < y; i++)
            {
                power *= x;
            }
            return power;
        }
        static double max(double[] x)
        {
            if (x.Length == 0)
            {
                Console.Write("There is no number = ");
                return 0;
            }
            Array.Sort(x);
            return x[x.Length - 1];
        }
        static double min(double[] x)
        {
            if (x.Length == 0)
            {
                Console.Write("There is no number = ");
                return 0;
            }
            Array.Sort(x);
            return x[0];
        }
    }
}
