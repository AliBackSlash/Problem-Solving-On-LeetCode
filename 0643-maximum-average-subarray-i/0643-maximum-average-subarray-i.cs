public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
         int len = nums.Length;
 if (len < k)
     return -1;
 double MaxAVG = 0;
 double sum = 0;


 for (int i = 0;i<k;i++)
     sum+= nums[i];

 MaxAVG = sum / k;

 for (int i = k;i<len;i++)
 {
     sum = sum - nums[i - k] + nums[i];
     MaxAVG = Math.Max(MaxAVG,sum/k);
 }

 return MaxAVG;
    }
}