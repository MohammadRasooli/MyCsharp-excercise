using System;

namespace ElevatorSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string lNumber = GetLargestNumber(input);
            string sNumber = GetSmallestNumber(input);
            int largestNumber = Convert.ToInt32(lNumber);
            int smallestNumber = Convert.ToInt32(sNumber);
            int n = 0;

            for (int i = smallestNumber; i < largestNumber; i++)
            {
                int check = i;

                for (int x = 0; x < input; x++)
                {
                    if (IsPrime(i))
                    {
                        n++;
                        i = i / 10;
                        if (n == input)
                        {
                            Console.WriteLine(check);
                        }
                    }
                    else
                    {
                        x = input;
                    }
                }
                i = check;
                n = 0;
            }
        }

        static string GetLargestNumber(int input)
        {
            return new string('9', input);
        }

        static string GetSmallestNumber(int input)
        {
            return "1" + new string('0', input - 1);
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number <= 3)
                return true;

            if (number % 2 == 0 || number % 3 == 0)
                return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }
    }
}