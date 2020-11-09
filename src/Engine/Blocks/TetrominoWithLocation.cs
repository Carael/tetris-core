namespace TetrisCore.Engine.Blocks
{
    public class TetrominoWithLocation
    {
        public TetrominoWithLocation(ITetromino tetromino, int row, int column)
        {
            Tetromino = tetromino;
            Row = row;
            Column = column;
        }

        public ITetromino Tetromino { get; }
        public int Row { get; }
        public int Column { get; }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveDown()
        {

        }
    }
}