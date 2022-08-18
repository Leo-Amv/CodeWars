public static class Kata
{
    public static int Solution(int value)
    {
        return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
    }
    public static void Main()
    {
        Console.WriteLine(Solution(100));
    }
}