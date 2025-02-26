public class Solution 
{
    public int MaxAbsoluteSum(int[] nums) 
    {
        int maxAbsSum = 0;
        int maxSoFar = 0;
        int minSoFar = 0;

        foreach (int num in nums) 
        {
            maxSoFar = Math.Max(num, maxSoFar + num);
            minSoFar = Math.Min(num, minSoFar + num);
            maxAbsSum = Math.Max(maxAbsSum, Math.Max(maxSoFar, -minSoFar));
        }

        return maxAbsSum;
    }
}