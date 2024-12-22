public class Solution
 {
    public int[] TwoSum(int[] nums, int target)
     {
        
        int[] indices = new int[2];
         for (int i = 0; i < nums.Length; i++)
          {
           for (int j = 0; j < nums.Length; j++)
           {
              if(i!=j)
 {
     if (nums[i] + nums[j] == target)
     {
         indices[0] = i;
         indices[1] = j;
         return indices;
     }
 }
     }
 }

 return nums;

    }
}