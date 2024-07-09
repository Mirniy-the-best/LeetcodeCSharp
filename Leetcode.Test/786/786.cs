namespace Leetcode.Test
{
    public class _786
    {
        public int[] KthSmallestPrimeFraction(int[] arr, int k)
        {
            var q = new PriorityQueue<(int,int),double>(k);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    q.Enqueue(new(arr[i], arr[j]), -(arr[i] * 1.0) / (arr[j] * 1.0));

                    if (q.Count > k)
                        q.Dequeue();
                }
            }

            return [q.Peek().Item1, q.Peek().Item2];
        }


    }
}