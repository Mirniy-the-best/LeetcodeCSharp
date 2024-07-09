namespace Leetcode.Test
{
    public class _394
    {
        public string DecodeString(string s)
        {
            var cnts = new Stack<int>();
            var vals = new Stack<string>();
            bool isDigit = false;

            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    if (!isDigit)
                        cnts.Push(c - '0');
                    else
                        cnts.Push(cnts.Pop() * 10 + (c - '0'));
                    isDigit = true;
                    continue;
                }

                isDigit = false;
                if(char.IsLetter(c))
                {
                    if (vals.Count > 0 && vals.Peek() != "[")
                        vals.Push(vals.Pop() + c);
                    else
                        vals.Push(c.ToString());
                    continue;
                }

                if (c == '[')
                {
                    vals.Push(c.ToString());
                    continue;
                }

                if(c == ']')
                {
                    var newval = vals.Pop();
                    do
                    {
                        var last = vals.Pop();
                        if (last != "[")
                            newval = last + newval;
                        else
                            break;
                    } while (vals.Count>0);

                    int cnt = cnts.Pop();

                    vals.Push(string.Concat(Enumerable.Repeat(newval, cnt)));
                }
            }

            return string.Concat(vals.Reverse());
        }

    }
}