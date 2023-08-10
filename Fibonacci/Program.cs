Console.WriteLine("Enter Number : ");
int repetitions = Convert.ToInt32(Console.ReadLine());
Console.Write("0, 1, 1, ");

int n1 = 1;
int n2 = 1;
int sum = 0;

for (int i = 1; i < repetitions; i++)
{
    sum = n1 + n2;
    n1 = n2;
    n2 = sum;


    Console.Write(n2 + ", ");
}
