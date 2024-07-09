namespace Leetcode.Test
{
    public class OrderedStream
    {
        int p = -1;
        string[] set;
        public OrderedStream(int n)
        {
            set = new string[n+1];
        }

        public IList<string> Insert(int idKey, string value)
        {
            var res= new List<string>();
            set[idKey] = value;
            if(p+1 == idKey)
            {
                do
                {
                    p++;
                    res.Add(set[p]);
                }
                while (set[p + 1] != null);
            }
            return res;
        }


    }
}