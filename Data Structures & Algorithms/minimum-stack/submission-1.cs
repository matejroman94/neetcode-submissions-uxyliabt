    public class MinStack
    {
        Stack<int> mainStack;
        Stack<int> minStack;
        public MinStack()
        {
            mainStack = new();
            minStack = new();
        }

        public void Push(int val)
        {
            if (mainStack.Count == 0 ||
                val <= minStack.Peek())
            {
                minStack.Push(val); 
            }

            mainStack.Push(val);
        }

        public void Pop()
        {
            int value = mainStack.Pop();
            if(value == minStack.Peek())
            {
                minStack.Pop();
            }
        }

        public int Top()
        {
            return mainStack.Peek();
        }

        public int GetMin()
        {
            return minStack.Peek();
        }
    }