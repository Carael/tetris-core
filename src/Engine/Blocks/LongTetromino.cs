namespace TetrisCore.Engine.Blocks
{
    public class LongTetromino : TetrominoBase, ITetromino
    {
        public LongTetromino() 
        : base(
            new byte[,]{
                {1},
                {1},
                {1},
                {1},
            })
        {
        }
    }
}