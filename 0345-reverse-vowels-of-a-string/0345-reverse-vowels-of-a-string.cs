public class Solution 
{
     bool IsAVowelLetter(char letter)
 {
     //The vowels are 'a', 'e', 'i', 'o', and 'u'
     return letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'||letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U';
 }
 public string ReverseVowels(string s)
 {
     int Right = s.Length - 1;
     int Left = 0;
     char[] ar = s.ToArray();
     while (Right > Left)
     {
         if (IsAVowelLetter(ar[Left]))
         {
             if (IsAVowelLetter(ar[Right]))
             {
                 (ar[Left], ar[Right]) = (ar[Right], ar[Left]);
                 Right--;
                 Left++;
             }
             else
                 Right--;
         }
         else
             Left++;
     }

     return string.Join("",ar);
 }
}