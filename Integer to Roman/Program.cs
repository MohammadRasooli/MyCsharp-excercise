using System;

namespace Integer_to_Roman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            double num = Convert.ToDouble(Console.ReadLine());

            while (num >= 1000)
            {
                num -= 1000;
                Console.Write("M");
            }
            while (num >= 900)
            {
                num -= 900;
                Console.Write("CM");
            }
            while (num >= 500)
            {
                num -= 500;
                Console.Write("D");
            }
            while (num >= 400)
            {
                num -= 400;
                Console.Write("CD");
            }
            while (num >= 100)
            {
                num -= 100;
                Console.Write("C");
            }
            while (num >= 90)
            {
                num -= 90;
                Console.Write("XC");
            }
            while (num >= 50)
            {
                num -= 50;
                Console.Write("L");
            }
            while (num >= 40)
            {
                num -= 40;
                Console.Write("XL");
            }
            while (num >= 10)
            {
                num -= 10;
                Console.Write("X");
            }
            if (num == 9)
            {
                num -= 9;
                Console.Write("IX");
            }
            if (num >= 5 && num <= 8)
            {
                num -= 5;
                Console.Write("V");
            }
            if (num == 4)
            {
                num -= 4;
                Console.Write("IV");
            }
            while (num >= 1 && num <= 3)
            {
                num -= 1;
                Console.Write("I");
            }
        }
    }
}
