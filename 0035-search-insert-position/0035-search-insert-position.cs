public class Solution {
    public int SearchInsert(int[] nums, int target)
 {
 int Start = 0, End = nums.Length - 1, midlle = -1;

 while (Start <= End)
 {
     midlle = Start + (End - Start) / 2;

     if(nums[midlle] == target)
         return midlle;
     else if(target  > nums[midlle])
         Start = midlle + 1;
     else
         End = midlle - 1;
    
 }
 return Start;
 }
}