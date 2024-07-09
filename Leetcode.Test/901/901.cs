namespace Leetcode.Test
{
    public class _901
    {
        public class StockSpanner
        {
            PriorityQueue<KeyValuePair<int,int>, int> _q = new PriorityQueue<KeyValuePair<int, int>, int>();
            public StockSpanner()
            {

            }

            public int Next(int price)
            {
                int cnt = 0;
                while (_q.Count > 0 && _q.Peek().Key <= price)
                {
                    cnt += _q.Dequeue().Value;
                }
                _q.Enqueue(new KeyValuePair<int, int>(price, cnt + 1), price);

                return cnt + 1;
            }
        }

    }
}