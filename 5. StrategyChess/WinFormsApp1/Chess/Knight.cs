namespace StrategyChess
{
    internal class Knight : IPiece
    {
        public Tuple<int, int>[] GetAvailableTiles()
        {
            return new Tuple<int, int>[]
            {
                new Tuple<int, int>(1, 2),
                new Tuple<int, int>(2, 1),
                new Tuple<int, int>(1, -2),
                new Tuple<int, int>(2, -1),
                new Tuple<int, int>(-1, 2),
                new Tuple<int, int>(-2, 1),
                new Tuple<int, int>(-1, -2),
                new Tuple<int, int>(-2, -1),
            };
        }
    }
}