int sum = 0;
for (int i = 112; i < 999; i++)
{
    string toString = i.ToString();

    if (toString[0] == toString[1] || toString[0] == toString[2])
    {
        if (!toString.Contains("0") && toString.Count(x => x == toString[0]) != 3)
        {
            sum++;
        }
    }
    else if (toString[1] == toString[2])
    {
        if (!toString.Contains("0") && toString.Count(x => x == toString[0]) != 3)
        {
            sum++;
        }
    }
}
Console.WriteLine(sum);