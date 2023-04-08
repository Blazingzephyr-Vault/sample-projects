using System.Linq;

namespace ArrayDecorator
{
    class Sort : ArrayDecorator
    {
        public Sort(Array array) : base(array)
        {

        }

        public override void DoAction()
        {
            _array.DoAction();
            _internalArray = (from p in _internalArray
                             orderby p
                             select p).ToArray();
        }
    }
}