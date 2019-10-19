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

            _view.Introduction();
        }

        //Main loop for running te game.
        public void runGame()
        {
            _view.GetInput();
        }
    }
}