public class Solution {
   public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
{
   HashSet<int> Hnums1 = new HashSet<int>(nums1);
   HashSet<int> Hnums2 = new HashSet<int>(nums2);

    List<int> result1 = new List<int>();
    List<int> result2 = new List<int>();

    foreach (int i in Hnums1)
    {
        if(!Hnums2.Contains(i))
            result1.Add(i);
    }
    
    foreach (int i in Hnums2)
    {
        if(!Hnums1.Contains(i))
            result2.Add(i);
    }

    return new List<IList<int>> { result1, result2 };

}

}