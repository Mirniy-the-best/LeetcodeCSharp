namespace Leetcode.Test
{
    public class _216
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            var lst = Enumerable.Range(1,9).ToList();
            var res = Search(lst, k, n);

            return res;
        }

        List<IList<int>> Search(List<int> lst, int k, int n) {
            var res = new List<IList<int>>();

            for (int i = 0; i < lst.Count; i++)
            {
                if (n - lst[i] < 0) continue;
                if (n - lst[i] == 0)
                    if (k > 1) continue;
                    else res.Add(new List<int> { lst[i] });

                if (n - lst[i] > 0 && k > 1) {
                    foreach (var l in Search(lst.Skip(i+1).ToList(), k - 1, n - lst[i]))
                    {
                        l.Add(lst[i]);
                        res.Add(l.Order().ToList());
                    }
                }
            }
            return res;
        }

    }
}