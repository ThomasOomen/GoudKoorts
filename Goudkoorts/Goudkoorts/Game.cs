using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Game
    {
        private WareHouse _wareHouse;
        private MarshallYard _marshallYard;
        private SwitchTrack _switchTrack;
        private SimpleTrack _simpleTrack;
        private Cart _cart;
        private Ship _ship;
        private Dock _dock;

        internal void initializeGame()
        {
            _wareHouse = new WareHouse();
            _wareHouse.Letter = "A";
            _wareHouse = new WareHouse();
            _wareHouse.Letter = "B";
            _wareHouse = new WareHouse();
            _wareHouse.Letter = "C";

        }


    }
}