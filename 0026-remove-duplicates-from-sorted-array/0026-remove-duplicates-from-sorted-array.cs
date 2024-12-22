public class Solution
{
   public int RemoveDuplicates(int[] nums)
{
    if (nums.Length <= 0)
    return 0;

int Key = 1;
for (int i=1;nums.Length>i;i++)
{
    if (nums[i] != nums[i-1])
    {
        nums[Key++] = nums[i];

    }
}
 return Key;
}
}