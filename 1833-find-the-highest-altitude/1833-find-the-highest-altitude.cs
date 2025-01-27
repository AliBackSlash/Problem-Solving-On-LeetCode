public class Solution {
    public int LargestAltitude(int[] gain) {
         if(gain.Length==0)
     return 0;

 int CurrentAltitude = 0, MaxAltitude = 0;

 for (int i = 0; i < gain.Length; i++)
 {
     CurrentAltitude = CurrentAltitude + gain[i];
     MaxAltitude = Math.Max(MaxAltitude, CurrentAltitude);
 }

 return MaxAltitude;
    }
}