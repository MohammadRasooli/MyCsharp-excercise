using System;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Roman numeral---> ");
            var romanNumeral = Console.ReadLine();
            var result = 0;
            for (int i = romanNumeral.Length - 1; i >= 0; i--)
            {
                switch (romanNumeral[i])
                {
                    case 'M':
                        result += 1000;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'C':
                        if (i + 1 < romanNumeral.Length)
                        {
                            switch (romanNumeral[i + 1])
                            {
                                case 'M':
                                    result -= 200;
                                    break;
                                case 'D':
                                    result -= 200;
                                    break;
                            }
                        }
                        result += 100;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'X':
                        if (i + 1 < romanNumeral.Length)
                        {
                            switch (romanNumeral[i + 1])
                            {
                                case 'C':
                                    result -= 20;
                                    break;
                                case 'L':
                                    result -= 20;
                                    break;
                            }
                        }
                        result += 10;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'I':
                        if (i + 1 < romanNumeral.Length)
                        {
                            switch (romanNumeral[i + 1])
                            {
                                case 'X':
                                    result -= 2;
                                    break;
                                case 'V':
                                    result -= 2;
                                    break;
                            }
                        }
                        result += 1;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}