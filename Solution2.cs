namespace LeetCodeTasks;

public class Solution2 {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        int i = 0;
        k %= n;
        
        int[] rotatedNums = new int[n];
        
        for ( ; i < n; i++) {
            rotatedNums[(i + k) % n] = nums[i];
        }
    
        for ( ; i < n; i++) {
            nums[i] = rotatedNums[i];
        }
    }
}