namespace Leetcode.Test
{
    public class _1291
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var result = new List<int>();
            string template = "123456789";
            var ll = low.ToString().Length;
            var hl = high.ToString().Length;

            for (int i = ll; i <= hl; i++)
            {
                for (int j = 0; j <= template.Length - i; j++)
                {
                    int cur = int.Parse(template.Substring(j, i));
                    if (cur >= low && cur <= high)
                        result.Add(cur);
                    if (cur > high)
                        return result;
                }
            }

            return result;
        }


    }
}