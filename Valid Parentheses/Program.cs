public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int n = 0;
        char[] temp = input.ToCharArray();
        if (temp[0] == ')') return false;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == '(') n++;
            if (temp[i] == ')') n--;
            if (n == -1) return false;
        }
        if (n == 0) return true;
        else return false;
    }
    public static void Main()
    {
        System.Console.WriteLine(ValidParentheses("(())((()())())"));
    }
}