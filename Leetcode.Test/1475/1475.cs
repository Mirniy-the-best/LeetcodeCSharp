namespace Leetcode.Test
{
    public class _1475
    {
        public int[] FinalPrices(int[] prices)
        {
            var stack = new Stack<int>();

            for (int i = prices.Length-1; i>=0; i--)
            {
                var currentPrice = prices[i];
                while (stack.Count > 0)
                {
                    if (stack.Peek() <= currentPrice)
                    {
                        prices[i]-= stack.Peek();
                        break;
                    } else {
                        stack.Pop();
                    }
                }

                stack.Push(currentPrice);
            }

            return prices;
        }


    }
}