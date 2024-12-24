public class Solution {
     bool IsAVowalLetter(char c)
     {
     return c == 'a' || c == 'e' || c == 'i' || c == 'u' || c == 'o';
     }
    public int MaxVowels(string s, int k) {
       if (s.Length == 0)
    return 0;

int maxVowels = 0;
int currentVowels = 0;

for (int i = 0; i < k; i++)
{
    if (IsAVowalLetter(s[i]))
    {
        currentVowels++;
    }
}
maxVowels = currentVowels;

for (int i = k; i < s.Length; i++)
{
    
    if (IsAVowalLetter(s[i - k]))
    {
        currentVowels--;
    }

    if (IsAVowalLetter(s[i]))
    {
        currentVowels++;
    }

    maxVowels = Math.Max(maxVowels, currentVowels);
}

return maxVowels;
}
    
}