
namespace ArrayDecorator
{
    class Mirror : ArrayDecorator
    {
        public Mirror(Array array) : base(array)
        {

        }

        public override void DoAction()
        {
            _array.DoAction();

            int l = _array.Length;
            int[] mid = new int[l];
            _internalArray.CopyTo(mid, 0);

            for (int i = 0; i < l; i++)
            {
                _internalArray[i] = mid[l - i - 1];
            }
        }
    }
}