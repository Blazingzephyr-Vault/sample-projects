
namespace StrategyChess
{
    internal interface IPiece
    {
        Tuple<int, int>[] GetAvailableTiles();
    }
}