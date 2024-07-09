using System.Linq;

namespace Leetcode.Test
{
    public class _648
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var index = dictionary
                .GroupBy(x=>x.First())
                .Select(x=> (x.Key, x.Order().ToArray()))
                .ToDictionary();

            var words = sentence
                .Split(' ')
                .Select(x =>
                {
                    if (index.TryGetValue(x[0], out var vals))
                        for (var j = 0; j < vals.Length; j++)
                            if (x.StartsWith(vals[j])) return vals[j];
                    return x;
                });

            return string.Join(' ', words);
        }


    }
}