using System;

public class RomanConvert
{
    public static string Solution(int n)
    {
        char[] array = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        string[] units = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = { "M", "MM", "MMM" };
        string str = n.ToString();
        string result = String.Empty;
        if (str.Length == 1)
        {
            return units[n - 1];
        }
        if (str.Length == 2)
        {
            if (n % 10 == 0) return tens[n / 10 - 1];
            else return tens[n / 10 - 1] + units[n % 10 - 1];
        }
        if (str.Length == 3)
        {
            if (n % 100 == 0) return hundreds[n / 100 - 1];
            if (n % 10 == 0) return hundreds[n / 100 - 1] + tens[0];
            else return hundreds[n / 100 - 1] + tens[(n % 100) / 10 - 1] + units[n % 10 - 1];
        }
        if (str.Length == 4)
        {
            if (n % 1000 == 0) return thousands[n / 1000 - 1];
            if (n % 100 == 0) return thousands[n / 1000 - 1] + hundreds[0];
            if (n % 10 == 0) return thousands[n / 1000 - 1] + hundreds[(n % 1000) / 100 - 1] + tens[(n % 100) / 10 - 1];
            else return thousands[n / 1000 - 1] + hundreds[(n % 1000) / 100 - 1] + tens[(n % 100) / 10 - 1] + units[n % 10 - 1];
        }
        throw new NotImplementedException();
    }
    public static void Main()
    {
        // for (int i = 10; i < 100; i++)
        // {
        Console.WriteLine(Solution(120));
        // }
    }
}