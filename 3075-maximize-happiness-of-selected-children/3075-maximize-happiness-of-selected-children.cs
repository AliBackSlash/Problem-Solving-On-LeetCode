public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {

 List<int> hs = new (happiness);
 hs.Sort();
 long CurrentMaxValue = 0;
 int decValue = 0;
 int len = hs.Count - 1;
 for (int i = 0; i < k; i++)
 {
     CurrentMaxValue += Math.Max((hs[len - i] - decValue++),0);
 }

 return CurrentMaxValue;
}
    
}