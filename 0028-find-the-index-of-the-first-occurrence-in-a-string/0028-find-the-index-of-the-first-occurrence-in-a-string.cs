 public class Solution
 {

     public int StrStr(string haystack, string needle)
     {
         if (haystack == null || needle == null || needle.Length > haystack.Length)
             return -1;
         if (needle == haystack)
             return 0;
         string s = "";
         int i = haystack.IndexOf(needle[0]);
         int DeletedCount = 0;
         if (i == -1)
             return i;
         //"mississippi", "issip"
         while (haystack.Length > needle.Length)
         {
             if (needle.Length > haystack.Length)
                 return -1;
             if (i + needle.Length > haystack.Length)
                 return -1;
             s = haystack.Substring(i, needle.Length);
             if (s == needle)
                 return i+ DeletedCount;
             haystack = haystack.Remove(i, 1);
             DeletedCount++;
             i = haystack.IndexOf(needle[0]);
             if (i == -1)
                 return i;
         }


         return -1;
     }
 }