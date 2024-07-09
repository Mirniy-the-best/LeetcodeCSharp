namespace Leetcode.Test
{
    public class _155
    {
        public class MinStack
        {
            Stack<(int val,int min)> _s = new Stack<(int val,int min)> ();
            public MinStack()
            {

            }

            public void Push(int val)
            {
                if (_s.TryPeek(out (int val, int min) last))
                    _s.Push((val, Math.Min(val, last.min)));
                else
                    _s.Push((val, val));
            }

            public void Pop()
            {
                _s.Pop();
            }

            public int Top()
            {
                return _s.Peek().val;
            }

            public int GetMin()
            {
                return _s.Peek().min;
            }
        }

    }
}