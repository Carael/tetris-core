namespace TetrisCore.Engine.Blocks
{
    public abstract class TetrominoBase : ITetromino
    {
        protected byte[,] _body;

        public TetrominoBase(byte[,] body)
        {
            _body = body;
        }

        public byte[,] Body => _body;

        public void Rotate()
        {
            int width = _body.GetUpperBound(0) + 1;
            int height = _body.GetUpperBound(1) + 1;

            byte[,] rotatedBody = new byte[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    int newRow = col;
                    int newCol = height - (row + 1);

                    rotatedBody[newCol, newRow] = _body[col, row];
                }
            }

            _body = rotatedBody;
        }
    }
}