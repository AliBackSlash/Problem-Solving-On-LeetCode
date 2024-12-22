public class Solution
{
    public string ReverseWords(string s)
 {
     s = s.Trim();

 List<string> strings = new List<string>();
 strings = s.Split(' ').ToList();
 StringBuilder Word = new StringBuilder();

 strings.RemoveAll((Sep) => string.IsNullOrEmpty(Sep));
 int Length = strings.Count;
 int LastIndex = Length;

 for (int i = 0; i < strings.Count; i++)
 {
     
     Word.Append(strings[--LastIndex]);

     if (i + 1 < Length)
         Word.Append(" ");

 }

 return Word.ToString();
 }
}