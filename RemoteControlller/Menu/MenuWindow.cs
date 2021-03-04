using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class MenuWindow
    {
        private const string textWindowMenu = "0 - Wyłącz wszystko\n"+
                                              "1 - Otwórz okna\n" +
                                              "2 - Zamknij okna\n" +
                                              "3 - Zmień stan\n" +
                                              "z - Zakończ\n" +
                                              "Wybierz opcję: ";

        public static void ShowMenu()
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n--->Sterowanie oknami<---");

            Console.ForegroundColor = currentForegroundColor;

            Console.WriteLine(textWindowMenu);
        }
    }
}
