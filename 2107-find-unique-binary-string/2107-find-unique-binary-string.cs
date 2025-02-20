public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        int Slen = nums[0].Length;
List<string> list = new List<string>(nums);
StringBuilder s = new StringBuilder();

Random random = new Random(1);
while(true)
{
    for (int i = 0; i < Slen; i++)
    {
        s.Append(random.Next(2));
    }

    if (!list.Contains(s.ToString()))
        return s.ToString();
    else
        s.Clear();
}
    }
}