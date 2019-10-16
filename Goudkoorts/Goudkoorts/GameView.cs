using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts
{
    public class GameView
    {
        public void intro()
        {
            Console.WriteLine();
            Console.WriteLine("|--------- Welkom bij Goudkoorts ---------|");
            Console.WriteLine();
            Console.WriteLine("|--------------- Toelichting--------------|");
            Console.WriteLine("|- Door op de toetsen 1 t/m 5 te drukken  |");
            Console.WriteLine("|- Kun je de rails verwisselen van standen|");
            Console.WriteLine("|-----------------------------------------|");

            Console.WriteLine();
            Console.WriteLine("Druk op een toets om te beginnen.");
            Console.ReadKey();
        }
    }
}