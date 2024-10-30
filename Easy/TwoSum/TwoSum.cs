namespace LeetcodeProblems.Easy.TwoSum;

/*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
  You may assume that each input would have exactly one solution, and you may not use the same element twice.
  You can return the answer in any order.
    Example 1:
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var s = 0;
        var memoryCache = 0;
        for (var i = 0; i < nums.Length; ++i)
        {
            ++s;
            memoryCache = target - nums[i];
            for (var j = s; j < nums.Length; ++j)
            {
                if (memoryCache.Equals(nums[j]))
                {
                    return new[] { i, j };
                }
            }
        }

        return [];
    }

    public int[] TwoSumV2(int[] nums, int target)
    {
        var valuesWithIndexes = ToDictionary(nums);
        int referrer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            referrer = target - nums[i];

            if (referrer == nums[i])
            {
                if (valuesWithIndexes[referrer].Count >= 2) return new[] { valuesWithIndexes[referrer].First(), valuesWithIndexes[referrer].Last() };
            }
            else
            {
                if (valuesWithIndexes.ContainsKey(referrer) && valuesWithIndexes.ContainsKey(nums[i]))
                {
                    return new[] { valuesWithIndexes[referrer].First(), valuesWithIndexes[nums[i]].First() };
                }
            }
        }

        throw new ArgumentException("exception");
    }
    
    public int[] TwoSumV3(int[] nums, int target)
    {
        var valuesWithIndexes = ToDictionary(nums);
        var referrer = 0;

        foreach (var t in nums)
        {
            referrer = target - t;

            if (referrer == t)
            {
                if (valuesWithIndexes[referrer].Count >= 2) return new[] { valuesWithIndexes[referrer].First(), valuesWithIndexes[referrer].Last() };
            }
            else
            {
                if (valuesWithIndexes.TryGetValue(referrer, out var value) && valuesWithIndexes.TryGetValue(t, out var value1))
                {
                    return new[] { value.First(), value1.First() };
                }
            }
        }

        return Array.Empty<int>();
    }


    private static Dictionary<int, List<int>> ToDictionary(int[] nums)
    {
        Dictionary<int, List<int>> dictionary = new();
        for (ushort i = 0; i < nums.Length; i++)
        {
            if (dictionary.ContainsKey(nums[i]))
            {
                dictionary[nums[i]].Add(i);
            }
            else
            {
                dictionary.Add(nums[i], new List<int> { i });
            }
        }

        return dictionary;
    }
}