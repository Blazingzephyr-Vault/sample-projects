
namespace ArrayDecorator
{
    class Positive : ArrayDecorator
    {
        public Positive(Array array) : base(array)
        {

        }

        public override void DoAction()
        {
            _array.DoAction();
            
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array._internalArray[i] < 0)
                {
                    _array._internalArray[i] *= -1;
                }
            }
        }
    }
}