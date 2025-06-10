public class Solution
{
    public string ReverseWords(string s)
 {
    
            StringBuilder reWordes = new StringBuilder();

            var lis = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            for (int i = lis.Length-1; i >= 0; i--)
            {
                reWordes.Append(lis[i]);
                reWordes.Append(' ');
            }
           
            return reWordes.ToString().Trim();
 }
}