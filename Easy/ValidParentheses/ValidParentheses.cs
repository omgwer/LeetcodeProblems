namespace LeetcodeProblems.Easy.ValidParentheses;

/*
    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
    determine if the input string is valid. 
*/
public class ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        char[] chars = s.ToCharArray();

        foreach (var ch in chars)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char peek = stack.Peek();
                if (IsAvailableToRemove(peek, ch))
                {
                    stack.Pop();
                    continue;
                }

                return false;
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }

        return false;
    }

    private static bool IsAvailableToRemove(char peek, char charInString)
    {
        return peek switch
        {
            '{' => charInString == '}',
            '(' => charInString == ')',
            '[' => charInString == ']',
            _ => false
        };
    }
}