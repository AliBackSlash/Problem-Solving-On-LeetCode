public class Solution {
    public string RemoveStars(string s) {
         Stack<char> chs = new Stack<char>();

        foreach (char C in s)
        {
            if(C!='*')
                chs.Push(C);
            else
                chs.Pop();
        }

        return string.Concat(chs.Reverse());
    }
}