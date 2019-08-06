using System;

namespace p_001_Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
    
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target) return new Int32[]{i,j};
                }
            }
            throw new Exception("not s");
        }
    }
}