public class Solution {
    public bool IsSubsequence(string s, string t) {

if (s=="")
return true;
            byte Sindex = 0;
            foreach (char c in t)            
                if (s[Sindex]==c)
                {
                    Sindex++;
                    if(Sindex >= s.Length)
                        return true;
                }
            
            return false;    }
}