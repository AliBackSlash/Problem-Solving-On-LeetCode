 public class Solution
 {
     public bool IsValid(string s) {  
        Stack<char> stack = new Stack<char>();  
        Dictionary<char, char> mapping = new Dictionary<char, char>() {  
            {')', '('},  
            {'}', '{'},  
            {']', '['}  
        };  

        foreach (char c in s) {  
            if (mapping.ContainsKey(c)) { // Closing bracket  
                if (stack.Count == 0 || stack.Pop() != mapping[c]) {  
                    return false; // Stack empty or mismatch  
                }  
            } else { // Opening bracket  
                stack.Push(c);  
            }  
        }  

        return stack.Count == 0; // True if stack is empty (all brackets matched)  
    }  

 }