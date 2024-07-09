namespace Leetcode.Test
{
    public class _506
    {
        public string[] FindRelativeRanks(int[] score)
        {
            var result = new string[score.Length];

            score
                .Select((val, i) => (val, i))
                .OrderByDescending(x => x.val)
                .Select((pair,i)=>(pair.i,i))
                .AsParallel()
                .ForAll(x => result[x.Item1] = toName(x.Item2));

            return result;
        }

        string toName(int num)
        {
            switch (num)
            {
                case 0: return "Gold Medal";
                case 1: return "Silver Medal";
                case 2: return "Bronze Medal";
                default: return (num+1).ToString();
            }
        }
    }
}