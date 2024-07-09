using System.Runtime.InteropServices;
using System.Xml;

namespace Leetcode.Test
{
    public class _100297
    {
        public int FindWinningPlayer(int[] skills, int k)
        {
            int imax = 0;
            int max = skills[0];
            int cnt = 0;
            for (int i = 1; i < skills.Length; i++)
            {
                if (skills[i] > max)
                {
                    max = skills[i];
                    cnt = 1;
                    imax = i;
                }
                else
                    cnt++;

                if(cnt == k) return imax;

            }
            return imax;

        }
    }
}