int numbersOfGrandmasDolls = Convert.ToInt32(Console.ReadLine());
int totalScream = 2;
int boy = 1;
int girl = 1;

for (int i = numbersOfGrandmasDolls; i > 1; i--)
{
    if (i > boy)
    {
        totalScream++;
        boy = i;
    }
    else if (i < girl)
    {
        totalScream++;
        girl = i;
    }
}

Console.WriteLine(totalScream);