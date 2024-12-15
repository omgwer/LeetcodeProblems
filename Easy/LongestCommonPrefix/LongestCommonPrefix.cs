using System.Text;

namespace LeetcodeProblems.Easy.LongestCommonPrefix;

/*
 Write a function to find the longest common prefix string amongst an array of strings.
 If there is no common prefix, return an empty string "".
 */
public class LongestCommonPrefix
{
    public string Do(string[] strs)
    {
        StringBuilder sb = new StringBuilder();

        if (strs.Length == 0)
        {
            return "";
        }

        for (int i = 0; i <= 1000; i++)
        {
            char iterableChar = char.MinValue;

            foreach (string str in strs)
            {
                if (str.Length < i+ 1)
                {
                    return sb.ToString();
                }

                char ch = str[i];

                if (iterableChar == char.MinValue)
                {
                    iterableChar = ch;
                    continue;
                }
                if (ch != iterableChar)
                {
                    return sb.ToString();
                }
            }

            sb.Append(iterableChar);
        }

        return sb.ToString();
    }
}