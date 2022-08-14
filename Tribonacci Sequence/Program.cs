public class Xbonacci
{
    public static double[] Tribonacci(double[] signature, int n)
    {
        double[] temp = new double[n];
        if (n < 3)
        {
            Array.Resize(ref signature, n);
            return signature;
        }
        else
        {
            temp[0] = signature[0];
            temp[1] = signature[1];
            temp[2] = signature[2];
            for (int i = 3; i < temp.Length; i++)
            {
                temp[i] = temp[i - 1] + temp[i - 2] + temp[i - 3];
            }
            return temp;
        }
    }
    public static void Main()
    {
        double[] signature = { 10, 6, 8 };
        double[] array = Tribonacci(signature, 2);
        System.Console.WriteLine(String.Join(",", array));
    }
}
