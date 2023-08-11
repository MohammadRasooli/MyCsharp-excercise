
int[] numbers = { 23, 12, 9, 42, 5 };

numbers = numbers.OrderByDescending(x => x).ToArray();

string[] sortedNumbers = Array.ConvertAll(numbers, x => x.ToString()).ToArray();

string join = string.Join(",", sortedNumbers);

string[] split = join.Split(",");

List<int> sum = new List<int>();


for (int i = 0; i < split.Length; i++)
{
    string x = split[i];
    int a = Convert.ToInt32(new string(x[0], 1));
    if (x.Length == 2)
    {
        int b = Convert.ToInt32(new string(x[1], 1)); ;
        sum.Add(a + b);
    }
    else
    {
        sum.Add(a);
    }
    Console.WriteLine($"{numbers[i]} = {sum[i]}");
}