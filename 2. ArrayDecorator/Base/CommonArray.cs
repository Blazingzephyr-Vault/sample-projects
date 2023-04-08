
namespace ArrayDecorator
{
    class CommonArray : Array
    {
        public CommonArray(params int[] array) : base(array.Length)
        {
            _internalArray = array;
        }
    }
}