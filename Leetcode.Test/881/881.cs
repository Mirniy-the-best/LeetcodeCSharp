namespace Leetcode.Test
{
    public class _881
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            var boats = 0;
            people = people.Order().ToArray();
            for (int i = 0, j = people.Length - 1; i <= j; boats++, j--)
                if (people[i] + people[j] <= limit)
                    i++;

            return boats;
        }


    }
}