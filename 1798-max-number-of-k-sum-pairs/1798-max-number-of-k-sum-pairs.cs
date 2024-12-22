public class Solution {
    public int MaxOperations(int[] nums, int k) {
         int len = nums.Length;
 if(len < 2) return 0;

 Array.Sort(nums);

 int L=0, R=len-1;
 int Count = 0;
 int SumOfRAndL = 0;
 while (L < R) {

     SumOfRAndL = nums[L] + nums[R];
     if (SumOfRAndL == k)
     { Count++; nums[L] = nums[R] = -1; L++; R--; }
     else if (SumOfRAndL > k)              
         R--;
     
     else 
         L++;

 }

 return Count;
    }
}