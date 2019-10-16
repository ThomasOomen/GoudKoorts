using System;

namespace Goudkoorts
{
    class Program
    {
        private Goudkoorts.GameController controller;

        static void Main(string[] args)
        {
            GameController gc = new GameController();
            gc.initializeGame();
        }
    }
}
