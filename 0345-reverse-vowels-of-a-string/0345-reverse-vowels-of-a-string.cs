public class Solution 
{
    bool IsAVowelLetter(char  letter)
{
    //The vowels are 'a', 'e', 'i', 'o', and 'u'
    return letter == 'a' || letter =='e'|| letter == 'i' || letter =='o'|| letter == 'u';
}
List<int> ReturnTheIndexesOfvowelsLetters(string s)
{
    List<int > indexies = new List<int>();
    s=s.ToLower();
    for (int i = 0; i < s.Length; i++)
    {
        if (IsAVowelLetter(s[i]))
            { indexies.Add(i); }
    }    
    return indexies;
}
public string ReverseVowels(string s)
{
    StringBuilder newS = new StringBuilder();
    newS.Append(s);

    List<int> Indexies = ReturnTheIndexesOfvowelsLetters(s);
    for (int i = 0; i < Indexies.Count; i++)
    {
        newS[Indexies[i]] = s[Indexies[Indexies.Count - 1 - i]];
    }
    return newS.ToString();
}
}