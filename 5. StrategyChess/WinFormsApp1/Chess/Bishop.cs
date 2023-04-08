namespace StrategyChess
{
    internal class Bishop : IPiece
    {
        public Tuple<int, int>[] GetAvailableTiles()
        {
            return new Tuple<int, int>[]
            {
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(2, 2),
                new Tuple<int, int>(3, 3),
                new Tuple<int, int>(4, 4),
                new Tuple<int, int>(5, 5),
                new Tuple<int, int>(6, 6),
                new Tuple<int, int>(7, 7),
                new Tuple<int, int>(1, -1),
                new Tuple<int, int>(2, -2),
                new Tuple<int, int>(3, -3),
                new Tuple<int, int>(4, -4),
                new Tuple<int, int>(5, -5),
                new Tuple<int, int>(6, -6),
                new Tuple<int, int>(7, -7),
                new Tuple<int, int>(-1, 1),
                new Tuple<int, int>(-2, 2),
                new Tuple<int, int>(-3, 3),
                new Tuple<int, int>(-4, 4),
                new Tuple<int, int>(-5, 5),
                new Tuple<int, int>(-6, 6),
                new Tuple<int, int>(-7, 7),
                new Tuple<int, int>(-1, -1),
                new Tuple<int, int>(-2, -2),
                new Tuple<int, int>(-3, -3),
                new Tuple<int, int>(-4, -4),
                new Tuple<int, int>(-5, -5),
                new Tuple<int, int>(-6, -6),
                new Tuple<int, int>(-7, -7)
            };
        }
    }
}