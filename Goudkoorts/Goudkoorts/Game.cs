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
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "south");

            //vanaf switchtrack 1 naar switchtrack 2
            _simpleTrack = new SimpleTrack("west", "east");

            // vanaf switchtrack 2 naar switchtrack 3
            _simpleTrack = new SimpleTrack("south", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "south");

            //vanaf switchtrack 3 naar 'uitgang'
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "north");
            _simpleTrack = new SimpleTrack("south", "north");
            _simpleTrack = new SimpleTrack("south", "north");
            _simpleTrack = new SimpleTrack("south", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            //hier moet de dock/crane aangemaakt worden
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "exit");

            //vanaf warehouse b naar switchtrack 1
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "north");

            //vanaf switchtrack 2 naar switchtrack 4
            _simpleTrack = new SimpleTrack("north", "east");
            _simpleTrack = new SimpleTrack("west", "south");

            //vanaf switchtrack 4 naar switchtrack 5
            _simpleTrack = new SimpleTrack("west", "east");

            //vanaf switchtrack 5 naar switchtrack 3
            _simpleTrack = new SimpleTrack("south", "east");
            _simpleTrack = new SimpleTrack("west", "north");

            //vanaf warehouse c naar switchtrack 4
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "north");

            //vanaf switchtrack 5 naar marshallyard
            _simpleTrack = new SimpleTrack("north", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "east");
            _simpleTrack = new SimpleTrack("west", "south");
            _simpleTrack = new SimpleTrack("north", "east");
            _simpleTrack = new SimpleTrack("east", "west");
            _simpleTrack = new SimpleTrack("east", "west");


            //Marshallyards
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");
            _marshallYard = new MarshallYard("east", "west");











        }


    }
}