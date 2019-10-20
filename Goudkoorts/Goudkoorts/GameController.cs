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
            _view.ShowGameField(_game.GetGameField(8, 8));
            _view.ShowGameField(_game.GetGameField(0, 5));
        }
    }
}