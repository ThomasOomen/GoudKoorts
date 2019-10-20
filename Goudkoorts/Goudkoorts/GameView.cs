using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class GameView
    {
        //print game info
        public void Introduction()
        {
            Console.WriteLine();
            Console.WriteLine("|--------- Welkom bij Goudkoorts ---------|");
            Console.WriteLine();
            Console.WriteLine("|--------------- Toelichting--------------|");
            Console.WriteLine("|- Door op de toetsen 1 t/m 5 te drukken  |");
            Console.WriteLine("|- Kun je de rails verwisselen van standen|");
            Console.WriteLine("|-----------------------------------------|");
        }

        //Read user input
        public int GetInput()
        {
            ConsoleKey playerInput = Console.ReadKey().Key;
            switch (playerInput)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.D4:
                    return 4;
                case ConsoleKey.D5:
                    return 5;
            }
            return -1;
        }

        //print gamefield
        public void ShowGameField(Track track)
        {
            switch(track)
            {
                case EmptySpace emptySpace:
                    Console.Write(" ");
                    break;

                case MarshallYard mashallYard:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("_");
                    Console.ResetColor();
                    break;

                case SwitchTrack switchTrack:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("+");
                    Console.ResetColor();
                    break;

                case WareHouse wareHouse:
                    Console.Write(wareHouse.getLetter());
                    break;

                case SimpleTrack simpleTrack:
                    Console.Write("_");
                    break;
            }
        }
    }
}