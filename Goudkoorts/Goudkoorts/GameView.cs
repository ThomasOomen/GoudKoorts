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
            Console.BackgroundColor = track.BackgroundColor;
            Console.ForegroundColor = track.ForegroundColor;
            Console.Write(track.ToChar());
        }

        public void Legend()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Switch track 1: Knop 1");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Switch track 2: Knop 2");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Switch track 3: Knop 3");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Switch track 4: Knop 4");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Switch track 5: Knop 5");
            Console.ResetColor();

        }
    }
}