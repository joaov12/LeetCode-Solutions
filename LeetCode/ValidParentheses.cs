// Runtime 56 ms
// Memory 39.54 MB


public static bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach(char c in s.ToCharArray())
    {
        if (c == '(')
        {
            stack.Push(')');
        }
        else if (c == '{')
        {
            stack.Push('}');
        }
        else if(c == '[')
        {
            stack.Push(']');
        }
        else if(stack.Count == 0 || stack.Pop() != c)
        {
            return false;
        }
    }
    return stack.Count == 0;
}
