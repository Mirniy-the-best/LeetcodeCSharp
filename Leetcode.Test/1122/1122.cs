namespace Leetcode.Test
{
    public class _1122
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] cashe = new int[1001];

            for (int i = 0; i < arr1.Length; i++)
                cashe[arr1[i]]++;

            var res = new List<int>();
            for (int i = 0; i < arr2.Length;i++)
            {
                for (int j = 0; j < cashe[arr2[i]]; j++)
                    res.Add(arr2[i]);
                cashe[arr2[i]] = 0;
            }

            for (int i = 0; i < cashe.Length; i++)
            {
                if (cashe[i] == 0) continue;
                for (int j = 0; j < cashe[i]; j++)
                    res.Add(i);
            }

            return res.ToArray();
        }


    }
}