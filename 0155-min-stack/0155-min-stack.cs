public class MinStack 
{
    private List<int> stack;
    private int count;

    public MinStack() 
    {
        stack = new List<int>();
        count = 0;
    }
    
    public void Push(int val) 
    {
        stack.Add(val);
        count++;
    }
    
    public void Pop() 
    {
        stack.RemoveAt(--count);
    }
    
    public int Top() 
    {
        return stack[count-1];
    }
    
    public int GetMin() 
    {
        return stack.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */