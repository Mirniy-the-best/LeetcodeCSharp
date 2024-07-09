namespace Leetcode.Test
{
    public class _735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var _stack = new Stack<int>();
            foreach (var asteroid in asteroids)
            {
                if (_stack.Count == 0)
                {
                    _stack.Push(asteroid);
                    continue;
                }

                var lastAst = _stack.Peek();
                //delete all previous asteroids, less, then current
                while (_stack.Count > 0 
                    && lastAst>0 && asteroid < 0
                    && Math.Abs(lastAst) < Math.Abs(asteroid))
                {
                    _stack.Pop();
                    if (_stack.Count == 0)
                        break;
                    lastAst = _stack.Peek();
                }

                //empty stack
                if (_stack.Count == 0)
                {
                    _stack.Push(asteroid);
                    continue;
                }

                //equals asteroid, destroy both
                if (lastAst > 0 && lastAst + asteroid == 0)
                {
                    _stack.Pop();
                    continue;
                }

                if (lastAst > 0 && asteroid < 0 && Math.Abs(lastAst) > Math.Abs(asteroid))
                    continue;

                _stack.Push(asteroid);
            }
            return _stack.Reverse().ToArray();
        }

    }
}