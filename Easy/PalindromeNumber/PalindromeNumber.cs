using Microsoft.VisualBasic;

namespace LeetcodeProblems.Easy.PalindromeNumber;

/// <summary>
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// </summary>
public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x < 10)
        {
            return true;
        }

        var inputValue = x.ToString();

        for (int i = 0, j = inputValue.Length -1 ; i < inputValue.Length / 2 ; i++, j--)
        {
            if (inputValue[i] != inputValue[j])
            {
                return false;
            }
        }

        return true;
    }
}