public class Solution {
    string Symbols = "IVXLCDM";
 short[] SymbolsValues = {1,5,10,50,100,500,1000};

  private short ReturnSymbolValue(char item)
  {
     return SymbolsValues[Symbols.IndexOf(item)];
  }

 public int RomanToInt(string s)
 {
    if (s.Length == 1) return ReturnSymbolValue(s[0]);

     int Value = 0;
     short CurrentSynbolValue = 0;
     for (byte i = 0; i < s.Length; i++)
     {
         CurrentSynbolValue = ReturnSymbolValue(s[i]);
         if (CurrentSynbolValue == 1000)
             Value += 1000;
         else if (CurrentSynbolValue == ReturnSymbolValue(s[i + 1]))
         { Value += ReturnSymbolValue(s[i + 1]) + CurrentSynbolValue; i++; }
         else if (CurrentSynbolValue > ReturnSymbolValue(s[i + 1]))
             Value += CurrentSynbolValue;
         else
         { Value += ReturnSymbolValue(s[i + 1]) - CurrentSynbolValue; i++; }

         if (++i == s.Length - 1)
         {
             Value += ReturnSymbolValue(s[i++]);
             break;
         }
         else
             i--;
     }
     return Value;
 }
}