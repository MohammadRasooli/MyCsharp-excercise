int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var mynum = 4;

Array.Sort(array: numbers);

int index = Array.BinarySearch(numbers, mynum);

if (index >= 0)
{
    Console.WriteLine(numbers[index] + " = " + index);
}
else
{
    Console.WriteLine("-1");
}