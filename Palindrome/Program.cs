class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number:");
        string num = Console.ReadLine();
        var reverse = Reverse(num);
        if (num == reverse)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    public static string Reverse(string get)
    {
        Char[] charArray = get.ToCharArray();
        Array.Reverse(charArray);
        string str = new string(charArray);
        return str;
    }
}