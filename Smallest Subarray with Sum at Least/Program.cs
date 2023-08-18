int[] numbers = new int[] { 1, 2, 3, 4, 5 };
int amountGiven = 8;
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (sum <= amountGiven)
    {
        Console.Write(numbers[i] + " ");
        sum += numbers[i];

        if (sum + numbers[i + 1] > amountGiven)
        {
            i = numbers.Length;
        }
    }
}