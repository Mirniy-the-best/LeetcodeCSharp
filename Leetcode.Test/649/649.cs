using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;

namespace Leetcode.Test
{
    public class _649
    {
        public string PredictPartyVictory(string senate)
        {
            var r = new Queue<int>();
            var d = new Queue<int>();
            for (int i = 0; i < senate.Length; i++)
                if (senate[i] == 'R')
                    r.Enqueue(i);
                else
                    d.Enqueue(i);

            int lastPosition = senate.Length;
            while (r.Count > 0 && d.Count > 0)
            {
                var cr = r.Dequeue();
                var cd = d.Dequeue();
                if (cr < cd) r.Enqueue(lastPosition++);
                else d.Enqueue(lastPosition++);
            }

            if (r.Count > 0)
                return "Radiant";
            return "Dire";
        }
    }
}