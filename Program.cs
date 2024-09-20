class Program
{
    public static void Main()
    {
        Stack<int> stack = new();
        stack.Push(1);
        stack.Push(2);
        stack.Push(1);
        Console.WriteLine(IsPolindrome(stack));
    }
    public static bool IsPolindrome(Stack<int> Stack1)
    {
        Stack<int> stack2 = new();
        if (Stack1.Count % 2 == 0)
        {
            while (Stack1.Count / 2 > 0)
            {
                stack2.Push(Stack1.Pop());
            }
        }
        else
        {
            List<int> ints = [];
            do
            {
                ints.Add(Stack1.Pop());
            }
            while (Stack1.Count / 2 - 1 > 0);
            Stack1.Pop();
            while (ints.Count > 0)
            {
                stack2.Push(ints.First());
                ints.RemoveAt(0);
            }
        }
        while (Stack1.Count > 0)
        {
            if (stack2.Pop() != Stack1.Pop())
            {
                return false;
            }
        }
        return true;
    }
}