public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string x in tokens)
        {
            switch (x){
            case "+":
                stack.Push(stack.Pop() + stack.Pop());
                break;

            case "-":
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
                break;
            
            case "*":
                stack.Push(stack.Pop() * stack.Pop());
                break;
            
            case "/":
                int c = stack.Pop();
                int d = stack.Pop();
                stack.Push((int) ((double) d / c));
                break;

            default:
                stack.Push(int.Parse(x));
                break;
            }
    
        }
        return stack.Pop();
    }
}
