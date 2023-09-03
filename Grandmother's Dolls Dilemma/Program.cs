/*
The grandmother has bought dolls for her two grandchildren, a boy and a girl.
he boy screams if he sees a doll bigger than any he has seen before,
and the girl screams if she sees a doll smaller than any she has seen before.
The grandmother needs to present the dolls in a way that minimizes the number of screams from her grandchildren.
*/

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