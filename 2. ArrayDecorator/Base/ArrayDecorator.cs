
namespace ArrayDecorator
{
    class ArrayDecorator : Array
    {
        protected Array _array;
        public ArrayDecorator(Array array) : base(array.Length)
        {
            _array = array;
            _internalArray = array._internalArray;
        }
    }
}