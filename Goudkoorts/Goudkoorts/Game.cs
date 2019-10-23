﻿using System;
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
        private EmptySpace _emptySpace;
        private Track[,] game2DArray = new Track[12, 9];
        private Random _Random;
        private List<WareHouse> _WarehouseList;

        public int Points { get; set; }

        internal void initializeGame()
        {
            game2DArray[0, 0] = _emptySpace = new EmptySpace();
            game2DArray[1, 0] = _emptySpace = new EmptySpace();
            game2DArray[2, 0] = _emptySpace = new EmptySpace();
            game2DArray[3, 0] = _emptySpace = new EmptySpace();
            game2DArray[4, 0] = _emptySpace = new EmptySpace();
            game2DArray[5, 0] = _emptySpace = new EmptySpace();
            game2DArray[6, 0] = _emptySpace = new EmptySpace();
            game2DArray[7, 0] = _emptySpace = new EmptySpace();
            game2DArray[8, 0] = _emptySpace = new EmptySpace();
            game2DArray[9, 0] = _emptySpace = new EmptySpace();//lokatie voor schip
            game2DArray[10, 0] = _emptySpace = new EmptySpace();
            game2DArray[11, 0] = _emptySpace = new EmptySpace();

            game2DArray[0, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);//uitgang
            game2DArray[1, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[2, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[3, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[4, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[5, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[6, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[7, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[8, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[9, 1] = _dock = new Dock(Direction.East, Direction.West, ConsoleColor.DarkRed);
            game2DArray[10, 1] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[11, 1] = _simpleTrack = new SimpleTrack(Direction.South, Direction.West);

            game2DArray[0, 2] = _emptySpace = new EmptySpace();
            game2DArray[1, 2] = _emptySpace = new EmptySpace();
            game2DArray[2, 2] = _emptySpace = new EmptySpace();
            game2DArray[3, 2] = _emptySpace = new EmptySpace();
            game2DArray[4, 2] = _emptySpace = new EmptySpace();
            game2DArray[5, 2] = _emptySpace = new EmptySpace();
            game2DArray[6, 2] = _emptySpace = new EmptySpace();
            game2DArray[7, 2] = _emptySpace = new EmptySpace();
            game2DArray[8, 2] = _emptySpace = new EmptySpace();
            game2DArray[9, 2] = _emptySpace = new EmptySpace();
            game2DArray[10, 2] = _emptySpace = new EmptySpace();
            game2DArray[11, 2] = _simpleTrack = new SimpleTrack(Direction.South, Direction.North);

            game2DArray[0, 3] = _wareHouse = new WareHouse('A'); // A
            _WarehouseList.Add(_wareHouse);  
            game2DArray[1, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[2, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[3, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.South);
            game2DArray[4, 3] = _emptySpace = new EmptySpace();
            game2DArray[5, 3] = _simpleTrack = new SimpleTrack(Direction.South, Direction.East);
            game2DArray[6, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[7, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[8, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[9, 3] = _simpleTrack = new SimpleTrack(Direction.West, Direction.South);
            game2DArray[10, 3] = _emptySpace = new EmptySpace();
            game2DArray[11, 3] = _simpleTrack = new SimpleTrack(Direction.South, Direction.North);

            game2DArray[0, 4] = _emptySpace = new EmptySpace();
            game2DArray[1, 4] = _emptySpace = new EmptySpace();
            game2DArray[2, 4] = _emptySpace = new EmptySpace();
            game2DArray[3, 4] = _switchTrack = new SwitchTrack(Direction.South, Direction.East, ConsoleColor.Red);// switch track 1
            game2DArray[4, 4] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[5, 4] = _switchTrack = new SwitchTrack(Direction.West, Direction.North, ConsoleColor.Green);// switch track 2
            game2DArray[6, 4] = _emptySpace = new EmptySpace();
            game2DArray[7, 4] = _emptySpace = new EmptySpace();
            game2DArray[8, 4] = _emptySpace = new EmptySpace();
            game2DArray[9, 4] = _switchTrack = new SwitchTrack(Direction.North, Direction.East, ConsoleColor.DarkYellow);//switch track 3
            game2DArray[10, 4] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[11, 4] = _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            game2DArray[0, 5] = _wareHouse = new WareHouse('B'); // B
            _WarehouseList.Add(_wareHouse);
            game2DArray[1, 5] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[2, 5] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[3, 5] = _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            game2DArray[4, 5] = _emptySpace = new EmptySpace();
            game2DArray[5, 5] = _simpleTrack = new SimpleTrack(Direction.North, Direction.East);
            game2DArray[6, 5] = _simpleTrack = new SimpleTrack(Direction.West, Direction.South);
            game2DArray[7, 5] = _emptySpace = new EmptySpace();
            game2DArray[8, 5] = _simpleTrack = new SimpleTrack(Direction.South, Direction.East);
            game2DArray[9, 5] = _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            game2DArray[10, 5] = _emptySpace = new EmptySpace();
            game2DArray[11, 5] = 

            game2DArray[0, 6] = _emptySpace = new EmptySpace();
            game2DArray[1, 6] = _emptySpace = new EmptySpace();
            game2DArray[2, 6] = _emptySpace = new EmptySpace();
            game2DArray[3, 6] = _emptySpace = new EmptySpace();
            game2DArray[4, 6] = _emptySpace = new EmptySpace();
            game2DArray[5, 6] = _emptySpace = new EmptySpace();
            game2DArray[6, 6] = _switchTrack = new SwitchTrack(Direction.South, Direction.East, ConsoleColor.Cyan);// switch track 4
            game2DArray[7, 6] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[8, 6] = _switchTrack = new SwitchTrack(Direction.West, Direction.South, ConsoleColor.Magenta);// switch track 5
            game2DArray[9, 6] = _emptySpace = new EmptySpace();
            game2DArray[10, 6] = _emptySpace = new EmptySpace();
            game2DArray[11, 6] = _emptySpace = new EmptySpace();
             
            game2DArray[0, 7] = _wareHouse = new WareHouse('C'); // C
            _WarehouseList.Add(_wareHouse);
            game2DArray[1, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[2, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[3, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[4, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[5, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[6, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.North);
            game2DArray[7, 7] = _emptySpace = new EmptySpace();
            game2DArray[8, 7] = _simpleTrack = new SimpleTrack(Direction.North, Direction.East);
            game2DArray[9, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[10, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.East);
            game2DArray[11, 7] = _simpleTrack = new SimpleTrack(Direction.West, Direction.South);

            game2DArray[0, 8] = _emptySpace = new EmptySpace();
            game2DArray[1, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[2, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[3, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[4, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[5, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[6, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[7, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[8, 8] = _marshallYard = new MarshallYard(Direction.East, Direction.West, ConsoleColor.DarkGreen);
            game2DArray[9, 8] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[10, 8] = _simpleTrack = new SimpleTrack(Direction.East, Direction.West);
            game2DArray[11, 8] = _simpleTrack = new SimpleTrack(Direction.North, Direction.West);

            _Random = new Random();
        }

        internal void SpawnCarts()
        {
            foreach(WareHouse warehouse in _WarehouseList)
            {
                if (_Random.Next(1, 100) <= SpawnChance())
                {
                    Cart cart = new Cart();
                    Console.WriteLine("Warehouse :" + warehouse.ToChar());
                    Console.WriteLine("NIEUWE CART AANGEMAAKT");
                }
            }
        }

        private int SpawnChance()
        {
            return (int)(0.05 * 50 + 5);
        }

        internal void CreateWareHouseList()
        {
            _WarehouseList = new List<WareHouse>();
        }

        public List<WareHouse> GetWareHouseList()
        {
            return _WarehouseList;
        }

        public Track GetGameField(int x, int y)
        {
            return game2DArray[x, y];
        }

        public void LinkTracks()
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 12; x++)
                {
                    if (y == 0 && x == 0)
                    {
                        game2DArray[x, y]._East = game2DArray[x + 1, y];
                        game2DArray[x, y]._South = game2DArray[x, y + 1];
                    }
                    else if (y == 8 && x == 11)
                    {
                        game2DArray[x, y]._West = game2DArray[x - 1, y];
                        game2DArray[x, y]._North = game2DArray[x, y - 1];
                    }
                    else if (y == 0)
                    {
                        game2DArray[x, y]._East = game2DArray[x + 1, y];
                        game2DArray[x, y]._West = game2DArray[x - 1, y];
                        game2DArray[x, y]._South = game2DArray[x, y + 1];
                    }
                    else if (y == 8)
                    {
                        game2DArray[x, y]._East = game2DArray[x + 1, y];
                        game2DArray[x, y]._West = game2DArray[x - 1, y];
                        game2DArray[x, y]._North = game2DArray[x, y -1];
                    }
                    else if (x == 0)
                    {
                        game2DArray[x, y]._East = game2DArray[x + 1, y];
                        game2DArray[x, y]._South = game2DArray[x, y + 1];
                        game2DArray[x, y]._North = game2DArray[x, y - 1];
                    }
                    else if (x == 11)
                    {
                        game2DArray[x, y]._West = game2DArray[x -1, y];
                        game2DArray[x, y]._South = game2DArray[x, y + 1];
                        game2DArray[x, y]._North = game2DArray[x, y - 1];
                    }

                    else
                    {
                        game2DArray[x, y]._North = game2DArray[x, y - 1];
                        game2DArray[x, y]._East = game2DArray[x + 1, y];
                        game2DArray[x, y]._South = game2DArray[x, y + 1];
                        game2DArray[x, y]._West = game2DArray[x - 1, y];
                    }
                }
            }
        }
    
        public void SwitchDirections(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    SwitchTrack switchtrack_1 = (SwitchTrack)game2DArray[3, 4];
                    switchtrack_1.SwitchInDirection();
                    break;
                case ConsoleKey.D2:
                    SwitchTrack switchtrack_2 = (SwitchTrack)game2DArray[5, 4];
                    switchtrack_2.SwitchOutDirection();
                    break;
                case ConsoleKey.D3:
                    SwitchTrack switchtrack_3 = (SwitchTrack)game2DArray[9, 4];
                    switchtrack_3.SwitchInDirection();
                    break;
                case ConsoleKey.D4:
                    SwitchTrack switchtrack_4 = (SwitchTrack)game2DArray[6, 6];
                    switchtrack_4.SwitchInDirection();
                    break;
                case ConsoleKey.D5:
                    SwitchTrack switchtrack_5 = (SwitchTrack)game2DArray[8, 6];
                    switchtrack_5.SwitchOutDirection();
                    break;
                default:
                    break;
            }
        }
    
    }


}