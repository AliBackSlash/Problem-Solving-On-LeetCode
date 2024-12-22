public class Solution {
  public string LongestCommonPrefix(string[] filteredArray)
 {
   
string prefix = filteredArray[0];

foreach (string s in filteredArray)
{
   
    while (!s.StartsWith(prefix))
    {
        prefix = prefix.Substring(0, prefix.Length - 1);
    }
}
return prefix;
 }


}