namespace Problems;

/*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
  You may assume that each input would have exactly one solution, and you may not use the same element twice.
  You can return the answer in any order.
    Example 1:
        Input: nums = [2,7,11,15], target = 9
        Output: [0,1]
        Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

public class TwoSum
{
    public int[] Execute(int[] nums, int target)
    {
        int firstValue = 0;
        int strafe = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            firstValue = nums[i];
            strafe++;
            int memCache = target - firstValue;

            for (int j = strafe; j < nums.Length; j++)
            {
                if (nums[j] == memCache)
                {
                    return new[] { i, j };
                }
            }
        }

        throw new ArgumentException("exception");
    }
}