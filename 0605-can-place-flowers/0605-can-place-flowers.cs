public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
 
 {  int Length = flowerbed.Length; 
            if (n == 0) return true;

if(Length >= 2)

  {if (flowerbed[Length-1] == 0 && flowerbed[Length - 2] == 0 ){ n--;flowerbed[Length-1]=1;};
              if (n == 0) return true;

  if (flowerbed[0] == 0  && flowerbed[1] == 0){n--;flowerbed[0]=1;};}

  if (n == 0) return true;

  if (Length == 0 || (Length == n && Length != 1) || Length < n) return false;

  if (Length == 1 && flowerbed[0] == 0 && n == 1) return true;



  else if (Length == 1 && flowerbed[0] == 1 && n == 1) return false;

  bool Frist = flowerbed[0] == 0;
 
  for (int i = 1; i < Length-1; i++)
  {

      if (Frist && flowerbed[i] == 0 && flowerbed[i + 1] == 0) { n--; flowerbed[i] = 1; }
      
      Frist = flowerbed[i] == 0;

      if (n == 0)  return true;    
  }
  return n == 0;
 }

}