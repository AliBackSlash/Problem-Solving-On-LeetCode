public class Solution {
    public int LongestSubarray(int[] nums) {
         if (nums.Length == 0 || (!nums.Contains(1))) return 0;
 else if (!nums.Contains(0)) return nums.Length - 1;

 int Left = 0, Right, MaxLongestOfOnes = 0;
 byte Zeros = 0;
 for(Right = 0;Right < nums.Length; Right++)
 {
     if (nums[Right] == 0)
         Zeros++;

     while(Zeros > 1)
     {
         if(nums[Left] == 0)
         {
             Zeros--;
         }
         Left++;
     }

     MaxLongestOfOnes = Math.Max(MaxLongestOfOnes, Right - Left + 1);
 }

 return MaxLongestOfOnes-1;
    }
}