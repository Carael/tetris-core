using TetrisCore.Engine.Blocks;

namespace TetrisCore
{
    public interface ITetrisGame
    {
        byte[,] Board { get; }
        TetrominoWithLocation CurrentTetromino { get; }
        ITetromino NextBlock { get; }
    }
}