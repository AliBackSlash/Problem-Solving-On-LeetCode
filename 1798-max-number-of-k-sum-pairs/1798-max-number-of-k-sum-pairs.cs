public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int MaxOper = 0, l = 0,sum, r = nums.Length - 1;
        Array.Sort(nums);      
        while (l < r)
        {
            sum = nums[l] + nums[r];
            if (sum == k)
            {
                MaxOper++;
                l++;
                r--;
            }
            else if (sum > k)
                r--;
            else
                l++;
        }
        return MaxOper;
    }
}