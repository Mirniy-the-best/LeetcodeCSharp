namespace Leetcode.Test
{
    public class _933
    {
        public class RecentCounter
        {
            Queue<int> _q;
            public RecentCounter()
            {
                _q = new Queue<int>();
            }

            public int Ping(int t)
            {
                while (_q.Count>0 && _q.Peek() < t-3000)
                    _q.Dequeue();
                _q.Enqueue(t);
                return _q.Count;
            }
        }

    }
}