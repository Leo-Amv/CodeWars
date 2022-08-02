public class Kata
{
    public static int FindShort(string s)
    {
        string[] words = s.Split(" ");
        string shortest = words[0];
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length <= shortest.Length) shortest = words[i];
        }
        return shortest.Length;
    }
}