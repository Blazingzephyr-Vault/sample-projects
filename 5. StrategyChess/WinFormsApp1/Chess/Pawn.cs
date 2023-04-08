
namespace StrategyChess
{
    internal class Pawn : IPiece
    {
        public Tuple<int, int>[] GetAvailableTiles()
        {
            return new Tuple<int, int>[]
            {
                new Tuple<int, int>(0, 1)
            };
        }
    }
}