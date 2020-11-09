namespace TetrisCore.Engine
{
    public interface IDisplayManager
    {
        void Draw(ITetrisGame state, IScoreManager score);
    }
}