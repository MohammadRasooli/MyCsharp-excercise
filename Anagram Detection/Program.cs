string str = "integral";
string str2 = "triangle";

Char[] charArray = str.ToCharArray();
Char[] charArray2 = str2.ToCharArray();

Array.Sort(charArray);
Array.Sort(charArray2);

string check = new string(charArray);
string check2 = new string(charArray2);

if (check == check2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}