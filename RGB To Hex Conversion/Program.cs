public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        if (r < 0) r = 0;
        if (g < 0) g = 0;
        if (b < 0) b = 0;
        if (r > 255) r = 255;
        if (g > 255) g = 255;
        if (b > 255) b = 255;
        return $"{r.ToString("X2").ToUpper()}{g.ToString("X2").ToUpper()}{b.ToString("X2").ToUpper()}";
    }
    public static void Main()
    {
        Console.WriteLine(Rgb(144, 195, 212));
    }
}