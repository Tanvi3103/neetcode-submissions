public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            switch (c) {
                case ')':
                    if (stack.Count == 0 || stack.Pop() != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0 || stack.Pop() != '[') return false;
                    break;
                case '}':
                    if (stack.Count == 0 || stack.Pop() != '{') return false;
                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }

        return stack.Count == 0;
    }
}
