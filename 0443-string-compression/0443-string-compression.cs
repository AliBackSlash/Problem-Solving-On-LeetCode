public class Solution {
    StringBuilder IsRepeatInString(char[] chars)
  {
      StringBuilder strb = new StringBuilder();
      for (short i = 0; i < chars.Length-1; i++)
      {
          if (chars[i] != chars[i+1])
              strb.Append(chars[i]);
      }


      strb.Append(chars[chars.Length - 1]);
      return strb;
  }

  public int Compress(char[] chars)
  {
      if (chars == null)
          return 0;
      if (chars.Length == 1)
          return 1;
      
      StringBuilder strToGetAllUniqeLets = new StringBuilder();
      StringBuilder s = new StringBuilder();
      strToGetAllUniqeLets = IsRepeatInString(chars);

      short count =0;
    
      foreach (char c in strToGetAllUniqeLets.ToString())
      {
           for (short i = 0; i < chars.Length; i++)
           {
              if (c == chars[i])
                 { count++;
                  if (i == chars.Length - 1) break; }

              if (c != chars[i + 1]&& chars[i + 1]!='\0')                        
                  { chars[i] = '\0'; break; }

              chars[i] = '\0';
          }
          if (count == 1)
              s.Append(c.ToString());
          else
              s.Append($"{c}{count}");
          count = 0;
      }
     for (short i = 0; i < s.Length; i++)
 {
     chars[i] = s[i];
 }

      return s.Length;
  }
}