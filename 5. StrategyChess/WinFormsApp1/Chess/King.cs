namespace StrategyChess
{
    internal class King : IPiece
    {
        public Tuple<int, int>[] GetAvailableTiles()
        {
            return new Tuple<int, int>[]
            {
                new Tuple<int, int>(-1, 1),
                new Tuple<int, int>(0, 1),
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(-1, 0),
                new Tuple<int, int>(1, 0),
                new Tuple<int, int>(-1, -1),
                new Tuple<int, int>(0, -1),
                new Tuple<int, int>(1, -1),
            };
        }
    }
}