public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int n = 0;
        bool x = false;
        if (input == "" || String.IsNullOrEmpty(input)) return true;
        char[] result = input.ToCharArray();
        char[] temp = new char[result.Length];
        int size = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == '(' || result[i] == ')')
            {
                temp[size] = result[i];
                size++;
            }
        }
        Array.Resize(ref temp, size);
        if (temp[0] == ')') return false;
        if (temp[temp.Length - 1] == '(') return false;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == '(')
            {
                n++;
                x = true;
            }
            if (temp[i] == ')')
            {
                n--;
                x = true;
            }
            if (n == -1) return false;
        }
        if (n == 0 && x == true) return true;
        else return false;
    }
    public static void Main()
    {
        System.Console.WriteLine(ValidParentheses("( )) (( )"));
    }
}