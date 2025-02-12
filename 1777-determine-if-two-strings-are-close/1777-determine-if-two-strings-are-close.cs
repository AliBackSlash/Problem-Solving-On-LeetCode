public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length)
     return false;

 HashSet<char> unLetters = new HashSet<char>(word1);

 List<int> iOfWor1Re = new List<int>();
 List<int> iOfWor2Re = new List<int>();
 int counterW1,counterW2;

 foreach (char C in unLetters)
 {
     counterW1 = counterW2 = 0;
     for (int i = 0; i < word1.Length; i++)
     {
         if (word1[i]==C)
             counterW1++;

         if (word2[i] == C)
             counterW2++;
     }
     iOfWor1Re.Add(counterW1);
     iOfWor2Re.Add(counterW2);


 }

 iOfWor1Re.Sort();
 iOfWor2Re.Sort();

 return iOfWor1Re.SequenceEqual(iOfWor2Re);
    }
}