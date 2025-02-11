public class Solution {
    public int PivotIndex(int[] nums) {
        int totalSum = nums.Sum();  
int leftSum = 0;  

for (int i = 0; i < nums.Length; i++)
{
    int rightSum = totalSum - leftSum - nums[i];  

    if (leftSum == rightSum)
    {
        return i;  
    }

    leftSum += nums[i];  
}

return -1; 
 }
    
}