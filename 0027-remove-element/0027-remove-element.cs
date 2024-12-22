public class Solution 
{
    public int RemoveElement(int[] nums, int val) {
         if (nums.Length <= 0)
     return 0;

 int Key = 0;

 for (int i = 0; nums.Length > i; i++)
 {
     if (nums[i]!=val)
     {
         nums[Key++] = nums[i];

     }
 }

     return Key;
    }
}