
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

bool check = false;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers.Count(x => x == numbers[i]) == 2)
    {
        Console.WriteLine($"{numbers[i]} is Duplicate.");
        i = numbers.Length;
        check = true;
    }
}
if (!check)
{
    Console.WriteLine("-1");
}