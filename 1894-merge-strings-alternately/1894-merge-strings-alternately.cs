public class Solution {
    public string MergeAlternately(string word1, string word2)
{
    StringBuilder s = new StringBuilder();
    byte Length = Convert.ToByte(word1.Length + word2.Length);
    for (int i = 0;i<Length-1;i++)
    {
        if (word1.Length > i && word2.Length > i)
            s.Append($"{word1[i]}{word2[i]}");
        else if (word1.Length >= i && word2.Length <= i)
            return s.Append($"{word1.Substring(i)}").ToString();
        else if (word1.Length <= i && word2.Length >= i)
            return s.Append($"{word2.Substring(i)}").ToString();
        else
            return s.ToString();

    }
    return s.ToString();
}
}