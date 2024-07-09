using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _1582
    {
        public int NumSpecial(int[][] mat)
        {
            int result = 0;
            List<Tuple<int, int, bool>> array = new List<Tuple<int, int, bool>>();

            for (int i = 0; i < mat.Length; i++)
                for (int j = 0; j < mat[i].Length; j++)
                    if (mat[i][j] == 1)
                        array.Add(new Tuple<int, int, bool>(i, j, false));

            array = array.OrderBy(x => x.Item1).ToList();
            for (int i = array.Count-1; i >0 ; i--)
            {
                if (array[i].Item1 == array[i - 1].Item1)
                {
                    array[i] = new Tuple<int, int, bool>(array[i].Item1, array[i].Item2, true);
                    array[i-1] = new Tuple<int, int, bool>(array[i-1].Item1, array[i-1].Item2, true);
                }
            }

            array = array.OrderBy(x => x.Item2).ToList();
            for (int i = array.Count - 1; i > 0; i--)
            {
                if (array[i].Item2 == array[i - 1].Item2)
                {
                    array[i] = new Tuple<int, int, bool>(array[i].Item1, array[i].Item2, true);
                    array[i - 1] = new Tuple<int, int, bool>(array[i - 1].Item1, array[i - 1].Item2, true);
                }
            }

            return array.Where(x => !x.Item3).Count();
        }
    }
}