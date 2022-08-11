public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        return Math.Clamp(r, 0, 255).ToString("X2") + Math.Clamp(g, 0, 255).ToString("X2") + Math.Clamp(b, 0, 255).ToString("X2");
    }
    public static void Main()
    {
        Console.WriteLine(Rgb(144, 195, 212));
    }
}