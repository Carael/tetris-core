using System;
using System.Threading.Tasks;
using TetrisCore.Engine;

namespace TetrisCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var gameEngine = new GameEngine();

            await gameEngine.StartAsync(default);
        }
    }
}
