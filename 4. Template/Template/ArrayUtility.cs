
using System.Globalization;

namespace Template
{
    internal class ArrayUtility<T>
        where T : IConvertible
    {
        public static void Display(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    if (array[i].ToInt32(NumberFormatInfo.CurrentInfo) == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                catch (Exception)
                {

                }                
            }
        }
    }
}