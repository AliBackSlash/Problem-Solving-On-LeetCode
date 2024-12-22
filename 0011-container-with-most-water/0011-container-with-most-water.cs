public class Solution {
    public int MaxArea(int[] height) {
      if (height.Length == 0)
    return 0;


int EndOfArray = height.Length-1, StartOfArray = 0;
int DiffLength = 0, hightLength = 0;
int MaxValues = 0;
while(StartOfArray<=EndOfArray)
{
    DiffLength=EndOfArray-StartOfArray;

    if (height[EndOfArray] < height[StartOfArray])
      { hightLength = height[EndOfArray]; EndOfArray--; }
    else
        { hightLength = height[StartOfArray]; StartOfArray++; }

    if (DiffLength * hightLength > MaxValues)
        MaxValues = DiffLength * hightLength;


}

return MaxValues;  
    }
}