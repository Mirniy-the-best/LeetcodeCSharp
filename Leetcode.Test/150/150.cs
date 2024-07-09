namespace Leetcode.Test
{
    public class _150
    {
        Dictionary<string, Func<int, int, int>> funcs = new Dictionary<string, Func<int, int, int>>()
        {
            {"+", (x,y)=>x+y },
            {"-", (x,y)=>x-y },
            {"*", (x,y)=>x*y },
            {"/", (x,y)=>x/y }
        };

        public int EvalRPN(string[] tokens)
        {
            var s = new Stack<int>();
            foreach (var token in tokens)
            {
                if(int.TryParse(token, out int num))
                {
                    s.Push(num);
                    continue;
                }
                int num2 = s.Pop();
                s.Push(funcs[token](s.Pop(), num2));
            }

            return s.Pop();
        }

    }
}