public class Solution {
    public int LongestOnes(int[] nums, int k)
 {
     int n = nums.Length;
     int left = 0, maxConsecutiveOnes = 0, zeroCount = 0; 
    
     for (int right = 0; right < n; right++)
     {
         if (nums[right] == 0)            
             zeroCount++;
         
         while (zeroCount > k)             
         { 
             if (nums[left] == 0)
             {
                 zeroCount--; 
             }
             left++;
         }
         maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, right - left + 1);
     }

     return maxConsecutiveOnes;
 }
}