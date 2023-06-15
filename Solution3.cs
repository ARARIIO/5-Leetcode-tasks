// Solution3: https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/674/
namespace LeetCodeTasks;

public class Solution3 {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();

        foreach (int num in nums1) {
            if (countMap.ContainsKey(num)) {
                countMap[num]++;
            }
            else {
                countMap[num] = 1;
            }
        }

        List<int> intersection = new List<int>();

        foreach (int num in nums2) {
            if (countMap.ContainsKey(num) && countMap[num] > 0) {
                intersection.Add(num);
                countMap[num]--;
            }
        }

        return intersection.ToArray();
    }
}
