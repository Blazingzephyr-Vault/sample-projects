
namespace Template
{
    static class Program
    {
        public static void Main()
        {
            ArrayUtility<float>.Display(new[]   { 0f, 9f, 75f, 0f, 67f          }); // Will skip some of these
            ArrayUtility<string>.Display(new[]  { "A", "B", "0", "D", "6", "0"  });

            float a = PowerCalculator<float>.Pow(3.91f, 9);
            float b = PowerCalculator<int>.Pow(4, 5);
            DateTime c = PowerCalculator<DateTime>.Pow(DateTime.Now, 2);            // Won't do anything
            float d = PowerCalculator<int>.Pow(2, 0);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);                                                   // DateTime.Now
            Console.WriteLine(d);                                                   // 2
        }
    }
}