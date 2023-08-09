using System;

namespace Calculate_the_chord_of_a_right_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Side A : ");
            double SideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Side B : ");
            double SideB = Convert.ToDouble(Console.ReadLine());

            double chord = Math.Sqrt((Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));

            Console.WriteLine($"chord is {chord}");
        }
    }
}
