using System;

public class RomanConvert
{
    public static string Solution(int n)
    {
        char[] array = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        string[] units = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = { "", "M", "MM", "MMM" };
        string str = n.ToString();
        string result = String.Empty;
        int x = n;
        int[] a = new int[str.Length];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = x % 10;
            x /= 10;
        }
        Array.Reverse(a);
        if (str.Length == 1)
        {
            return units[a[0]];
        }
        if (str.Length == 2)
        {
            return tens[a[0]] + units[a[1]];
        }
        if (str.Length == 3)
        {
            return hundreds[a[0]] + tens[a[1]] + units[a[2]];
        }
        if (str.Length == 4)
        {
            return thousands[a[0]] + hundreds[a[1]] + tens[a[2]] + units[a[3]];
        }
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