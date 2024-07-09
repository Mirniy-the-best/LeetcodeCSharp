namespace Leetcode.Test
{
    public class _01
    {
        public int MinimumCost(int[] nums)
        {
            var sum = nums[0];
            var _q = new PriorityQueue<int, int>();
            for (int i = 1; i < nums.Length; i++)
            {
                _q.Enqueue(nums[i], nums[i]);
            }
            return sum + _q.Dequeue() + _q.Dequeue();
        }

    }
}