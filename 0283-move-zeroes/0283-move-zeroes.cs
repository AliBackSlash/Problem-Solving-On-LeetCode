public class Solution {
    public void MoveZeroes(int[] nums) {
        int newIndecator = 0;

foreach (int i in nums)
    if (i != 0)
       { nums[newIndecator] = i; newIndecator++; }

for (int i = newIndecator; i < nums.Length; i++)
    nums[i] = 0;
    }
}