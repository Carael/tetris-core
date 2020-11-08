namespace TetrisCore.Engine.Blocks
{
    public class SquareTetromino : TetrominoBase, ITetromino
    {
        public SquareTetromino() : base(
            new byte[,]{
                {1,1},
                {1,1},
            })
        {
        }
    }
}