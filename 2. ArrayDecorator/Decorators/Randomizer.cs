using System;

namespace ArrayDecorator
{
    class Randomizer : ArrayDecorator
    {
        private readonly Random _random;
        public Randomizer(Array array) : base(array)
        {
            _random = new Random();
        }

        public override void DoAction()
        {
            _array.DoAction();
            
            for (int i = 0; i < _array.Length; i++)
            {
                _array._internalArray[i] = _random.Next(-100, 100);
            }
        }
    }
}