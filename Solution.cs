// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/549/
namespace LeetCodeTasks;

public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }
}
