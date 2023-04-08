using System;

namespace ArrayDecorator
{
    abstract class Array
    {
        public int Length => _internalArray.Length;
        public int[] _internalArray;
        public int _n;

        public Array(int n)
        {
            _internalArray = new int[n];
            _n = n;
        }

        public virtual void DoAction()
        {

        }

        public string Write() => String.Join(" ", _internalArray);
    }
}