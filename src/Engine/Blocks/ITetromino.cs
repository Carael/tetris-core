namespace TetrisCore.Engine.Blocks
{
    public interface ITetromino
    {
        byte[,] Body { get; }

        void Rotate();
    }
}