namespace Leetcode.Test
{
    public class _1518
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int empty = 0;
            int drank = 0;

            while(numBottles > 0 || empty >= numExchange)
            {
                numBottles += empty / numExchange;
                empty = empty % numExchange;
                drank += numBottles;
                empty += numBottles;
                numBottles = 0;
            }

            return drank;
        }


    }
}