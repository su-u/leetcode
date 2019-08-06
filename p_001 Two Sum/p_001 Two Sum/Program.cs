using System;
using System.Collections.Generic;
using System.Linq;

namespace p_001_Two_Sum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var n = new Solution().TwoSum(new []{2,7,11,15}, 9);
            Console.WriteLine($"{n?[0]} {n?[1]}");
        }
    }
    
    public class Solution1 {
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
    
    public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = Enumerable.Range(0, nums.Length).ToDictionary(i => nums[i].GetHashCode());
            for (var i = 0; i < nums.Length; i++)
            {
                var search = target - nums[i];
                if (dict.ContainsKey(search.GetHashCode()) && dict[search.GetHashCode()] != i)
                {
                    return new[] {i, dict[search.GetHashCode()]};
                }
            }
            throw new ArgumentException("No two sum solution");
        }
    }
}