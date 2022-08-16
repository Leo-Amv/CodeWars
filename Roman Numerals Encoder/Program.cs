using System;

public class RomanConvert
{
    public static string Solution(int n)
    {
        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = { "", "M", "MM", "MMM" };
        string result = String.Empty;
        result += thousands[(n / 1000) % 10];
        result += hundreds[(n / 100) % 10];
        result += tens[(n / 10) % 10];
        result += units[n % 10];
        return result;
        throw new NotImplementedException();
    }
    public static void Main()
    {
        // for (int i = 10; i < 100; i++)
        // {
        Console.WriteLine(Solution(1990));
        // }
    }
}