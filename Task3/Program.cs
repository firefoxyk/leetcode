using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] sum = new int[2];
            if (nums.Length == 2) { if (nums.Sum() == target) { sum[0] = 0; sum[1] = 1; return sum; } }
            else if (nums[0] + nums[nums.Length-1] == target) { sum[0] = 0; sum[1] = nums.Length-1; }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (i == j) { continue; }
                        else
                        { if (nums[i] + nums[j] == target) { sum[0] = i; sum[1] = j; return sum; } }
                    }
                }
            }

            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] ints = new int[] { 3, 2, 4 };
            int target =  6;
            int[] arrau = sol.TwoSum(ints, target);
            for(int i=0;i<arrau.Length;i++) { Console.WriteLine(arrau[i]); }

        }
    }
}