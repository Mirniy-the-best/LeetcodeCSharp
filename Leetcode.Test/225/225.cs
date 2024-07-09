using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Test
{
    public class _225
    {
        public class MyStack
        {
            private Queue<int> _queue = new Queue<int>();

            public MyStack()
            {

            }

            public void Push(int x)
            {
                _queue.Enqueue(x);
                for (int i = 0; i < _queue.Count-1; i++)
                    _queue.Enqueue(_queue.Dequeue());
            }

            public int Pop()
            {
                return _queue.Dequeue();
            }

            public int Top()
            {
                return _queue.Peek();
            }

            public bool Empty()
            {
                return _queue.Count == 0;
            }
        }

    }
}