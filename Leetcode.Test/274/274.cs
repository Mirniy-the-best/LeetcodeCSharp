using System.Linq;

namespace Leetcode.Test
{
    public class _274
    {
        public int HIndex(int[] citations)
        {
            citations = citations.OrderByDescending(x=>x).ToArray();
            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] == 0)
                    break;

                if (citations[i] == i + 1)
                    return citations[i];

                if (citations[i] < i + 1)
                    return i;
            }
            return citations.Count(x=>x>0);
        }
    }
}