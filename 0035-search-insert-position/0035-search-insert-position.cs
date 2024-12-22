public class Solution {
    public int SearchInsert(int[] nums, int target)
 {
     int length = nums.Length;
     if (length == 0) return 0;


     for (short index = 0; nums.Length > index; index++)
     {

         if (nums[index] == target)
             return index;
         if (nums[index] > target)
             return index;
     }

     if (nums[length-1] < target)
         return length;

     return -1;
 }
}