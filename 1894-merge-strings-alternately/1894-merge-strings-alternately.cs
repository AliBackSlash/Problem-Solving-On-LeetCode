public class Solution {

    public string MergeAlternately(string word1, string word2)
{
    StringBuilder result = new ();

    int len = word1.Length < word2.Length ? word1.Length : word2.Length;
    int i;
    for (i = 0; i < len; i++)
    {
        result.Append(word1[i].ToString() + word2[i].ToString());
    }

    if (word1.Length != word2.Length)
        result.Append(word1.Length > word2.Length ? word1.Substring(i).ToString() : word2.Substring(i).ToString());

    return result.ToString();
}
}