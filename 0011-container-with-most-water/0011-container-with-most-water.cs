public class Solution {
    public int MaxArea(int[] height) {
 int MaxValue = 0;
 int l = 0, r = height.Length - 1;
 while (l < r)
 {

     MaxValue = Math.Max(MaxValue, Math.Min(height[l], height[r]) * (r - l));

     if (height[l] > height[r]) r--; else l++;
 }

 return MaxValue; 
    }
}