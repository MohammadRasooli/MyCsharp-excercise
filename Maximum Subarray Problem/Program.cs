List<int> nums = new List<int> { -1, -2, 5, -4, 8, -2, 1, -3 };

int maxEndingHere = nums[0];
int maxSoFar = nums[0];
int startIndex = 0;
int endIndex = 0;

for (int i = 1; i < nums.Count; i++)
{
    maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
    if (maxEndingHere == nums[i])
    {
        startIndex = i;
    }
    if (maxEndingHere > maxSoFar)
    {
        maxSoFar = maxEndingHere;
        endIndex = i;
    }
}
Console.WriteLine($"Start Index: {startIndex}\nEnd Index: {endIndex}\nMax Sum: {maxSoFar}");