using System;

namespace BMI_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Height: ");
            var Height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Your Weight: ");
            var Weight = Convert.ToDouble(Console.ReadLine());

            var bmi = Weight / Math.Pow(Height / 100, 2);
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
            else
            {
                Console.WriteLine("something wrong!");
            }
        }
    }
}
