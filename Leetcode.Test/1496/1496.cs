using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1496
    {
        Dictionary<int, HashSet<int>> log = new Dictionary<int, HashSet<int>>();

        public bool IsPathCrossing(string path)
        {
            int x = 0;
            int y = 0;
            AddPoint(x,y);

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'N')
                {
                    y++;
                    if (!AddPoint(x, y)) return true;
                }
                if (path[i] == 'S')
                {
                    y--;
                    if (!AddPoint(x, y)) return true;
                }
                if (path[i] == 'W')
                {
                    x--;
                    if (!AddPoint(x, y)) return true;
                }
                if (path[i] == 'E')
                {
                    x++;
                    if (!AddPoint(x, y)) return true;
                }
            }
            return false;
        }

        bool AddPoint(int x, int y)
        {
            if (!log.ContainsKey(x))
            {
                log.Add(x, new HashSet<int>() { y });
                return true;
            }
            if(log[x].Contains(y))
                return false;

            log[x].Add(y);
            return true;
        }
    }
}