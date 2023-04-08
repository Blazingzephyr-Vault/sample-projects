
using System.Globalization;

namespace Template
{
    internal class PowerCalculator<T>
        where T : IConvertible, new()
    {
        public static T? Pow(T x, uint y)
        {
            if (y > 0)
            {
                try
                {
                    double input = x.ToDouble(NumberFormatInfo.InvariantInfo);
                    double result = input;

                    for (int i = 0; i < y - 1; i++)
                    {
                        result *= input;
                    }

                    return (T)Convert.ChangeType(result, typeof(T));
                }
                catch (Exception)
                {
                    return x;
                }
            }
            else return x;
        }
    }
}