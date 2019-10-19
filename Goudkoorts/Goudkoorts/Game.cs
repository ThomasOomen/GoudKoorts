using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class Game
    {
        private String _north;
        private String _east;
        private String _south;
        private String _west;

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


            //vanaf warehouse a naar switchtrack 1
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.South);

            //vanaf switchtrack 1 naar switchtrack 2
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);

            // vanaf switchtrack 2 naar switchtrack 3
            _simpleTrack = new SimpleTrack(Direction.South, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.South);

            //vanaf switchtrack 3 naar 'uitgang'
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            _simpleTrack = new SimpleTrack(Direction.South, Direction.North);   
            _simpleTrack = new SimpleTrack(Direction.South, Direction.North);
            _simpleTrack = new SimpleTrack(Direction.South, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);

            //Dock
            _dock = new Dock(Direction.East, Direction.West);
            //Dock

            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West); // eind van het spelveld.

            //vanaf warehouse b naar switchtrack 1
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.North);

            //vanaf switchtrack 2 naar switchtrack 4
            _simpleTrack = new SimpleTrack(Direction.North, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.South);

            //vanaf switchtrack 4 naar switchtrack 5
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);

            //vanaf switchtrack 5 naar switchtrack 3
            _simpleTrack = new SimpleTrack(Direction.South, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.North);

            //vanaf warehouse c naar switchtrack 4
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            //vanaf switchtrack 5 naar marshallyard
            _simpleTrack = new SimpleTrack(Direction.North, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.West, Direction.South);
            _simpleTrack = new SimpleTrack(Direction.North, Direction.East);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            _simpleTrack = new SimpleTrack(Direction.East, Direction.West);

            //Marshallyards
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
            _marshallYard = new MarshallYard(Direction.East, Direction.West);
        }
    }
}