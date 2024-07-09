namespace Leetcode.Test
{
    public class _557
    {
        public string ReverseWords(string s)
        {
            return String.Join(" ",
                new String(s.Reverse().ToArray())
                    .Split()
                    .Reverse()
                    );

        }


    }
}