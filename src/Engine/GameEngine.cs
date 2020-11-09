using System;
using System.Threading;
using System.Threading.Tasks;

namespace TetrisCore.Engine
{
    public class GameEngine
    {
        private readonly ITetrisGame _game;
        private readonly IInputHandler _inputHandler;
        private readonly IDisplayManager _displayManager;
        private readonly IScoreManager _scoreManager;

        public GameEngine(
            ITetrisGame game,
            IInputHandler inputHandler,
            IDisplayManager displayManager,
            IScoreManager scoreManager)
        {
            _game = game;
            _inputHandler = inputHandler;
            _displayManager = displayManager;
            _scoreManager = scoreManager;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            while (true)
            {
                var input = _inputHandler.GetInput();


                _displayManager.Draw(_game, _scoreManager);
                await Task.Delay(TimeSpan.FromMilliseconds(16.67), cancellationToken);
            }
        }

    }
}