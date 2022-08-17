public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int n = 0;
        foreach (char t in input)
        {
            if (t == '(')
            {
                n++;
            }
            else if (t == ')')
            {
                n--;

                if (n < 0)
                {
                    return false;
                }
            }
        }

        return n == 0;
    }
}