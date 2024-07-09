namespace Leetcode.Test
{
    public class _739
    {
        public int[] DailyTemperatures(int[] temperatures)
        {
            var res = new int[temperatures.Length];
            var stack = new Stack<int>();
            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                while(stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
                {
                    stack.Pop();
                }

                if (stack.Count > 0)
                    res[i] = stack.Peek() - i;

                stack.Push(i);
            }

            return res;
        }

    }
}