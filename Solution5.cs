namespace LeetCodeTasks;

public class Solution5 {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']') {
                if (stack.Count == 0 || !IsMatchingBracket(stack.Pop(), c)) {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
    private bool IsMatchingBracket(char open, char close) {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}