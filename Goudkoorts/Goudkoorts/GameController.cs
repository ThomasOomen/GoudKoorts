using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class GameController
    {
        private GameView _view;
        private Game _game;

        //Initialize game, build playfield
        public void initializeGame()
        {
            _game.initializeGame();
        }

        //Main loop for running te game.
        public void runGame()
        {

        }
    }
}