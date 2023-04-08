namespace StrategyChess
{
    internal class Rook : IPiece
    {
        public Tuple<int, int>[] GetAvailableTiles()
        {
            return new Tuple<int, int>[]
            {
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(2, 0),
                new Tuple<int, int>(3, 0),
                new Tuple<int, int>(4, 0),
                new Tuple<int, int>(5, 0),
                new Tuple<int, int>(6, 0),
                new Tuple<int, int>(7, 0),
                new Tuple<int, int>(-1, 0),
                new Tuple<int, int>(-2, 0),
                new Tuple<int, int>(-3, 0),
                new Tuple<int, int>(-4, 0),
                new Tuple<int, int>(-5, 0),
                new Tuple<int, int>(-6, 0),
                new Tuple<int, int>(-7, 0),
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(0, 2),
                new Tuple<int, int>(0, 3),
                new Tuple<int, int>(0, 4),
                new Tuple<int, int>(0, 5),
                new Tuple<int, int>(0, 6),
                new Tuple<int, int>(0, 7),
                new Tuple<int, int>(0, -1),
                new Tuple<int, int>(0, -2),
                new Tuple<int, int>(0, -3),
                new Tuple<int, int>(0, -4),
                new Tuple<int, int>(0, -5),
                new Tuple<int, int>(0, -6),
                new Tuple<int, int>(0, -7),
            };
        }
    }
}