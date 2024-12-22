public class Solution {
     public bool[] KidsWithCandies(int[] candies, int extraCandies)
  {
       int Length = candies.Length;
 bool[] result = new bool[Length]; 
 int Max = 0;

 for (int i = 0; i < Length; i++)
 {
     if (candies[i] > Max)
     {
         Max = candies[i];
     }
 }

 for (int i = 0; i< Length;i++)
 {
     result[i] = (candies[i] + extraCandies >= Max);                 
 }
 return result;
  }
}