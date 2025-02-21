public class Solution {
    public bool Check(int[] nums) {
        int count = 0;  
        int n = nums.Length;
        
        for (int i = 0; i < n - 1; i++) {
            if (nums[i] > nums[i + 1]) {
                count++;
            }
        }
        
        if (nums[n - 1] > nums[0]) {
            count++;
        }
        
        if (count > 1) {
            return false;
        }
        
        return true;
    }
}