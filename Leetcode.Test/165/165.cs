namespace Leetcode.Test
{
    public class _165
    {
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.').Select(x=>int.Parse(x)).ToArray();
            var v2 = version2.Split('.').Select(x => int.Parse(x)).ToArray();

            if (v1.Length < v2.Length)
                return -CompareVersion(version2, version1);

            for (int i = 0; i < v1.Length; i++)
            {
                if (i >= v2.Length)
                    if (v1[i] > 0) return 1;
                    else continue;

                if (v1[i] < v2[i]) return -1;
                if (v1[i] > v2[i]) return 1;
            }

            return 0;
        }


    }
}