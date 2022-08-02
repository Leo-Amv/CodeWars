using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        str = Regex.Replace(str, "[AaEeOoiIuU]", "");
        return str;
    }
}