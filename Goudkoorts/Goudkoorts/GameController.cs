using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class GameController
    {
        private GameView _view;
        private Game _game;

        public GameController()
        {
            initializeGame();
        }

        //Initialize game, build playfield
        public void initializeGame()
        {
            _view = new GameView();
            _game = new Game();
            _view.Introduction();
            _game.initializeGame();
            GetGameField();
        }

        //Main loop for running te game.
        public void runGame()
        {
            _view.GetInput();
        }

        public void GetGameField()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    _view.ShowGameField(_game.GetGameField(x, y));
                }
                Console.WriteLine();
            }
            _view.Legend();
        }
    }
}