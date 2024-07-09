namespace Leetcode.Test
{
    public class _2225
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var participants = new Dictionary<int, int>();
            foreach ( var match in matches )
            {
                if (!participants.ContainsKey(match[0]))
                    participants.Add(match[0], 0);
                if (!participants.ContainsKey(match[1]))
                    participants.Add(match[1], 1);
                else
                    participants[match[1]]++;
            }
            var result = new List<IList<int>>
            {
                new List<int>(),
                new List<int>()
            };

            foreach (var participant in participants.Where(p => p.Value < 2).OrderBy(x=>x.Key))
            {
                if (participant.Value == 0)
                    result[0].Add(participant.Key);
                else
                    result[1].Add(participant.Key);
            }

            return result;
        }

    }
}