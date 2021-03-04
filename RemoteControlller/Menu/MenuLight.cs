using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class MenuLight
    {
        private const string textLightMenu = "0 - Wyłącz wszystko\n" +
                                             "1 - Włącz światło\n" +
                                             "2 - Wyłącz światło\n" +
                                             "3 - Zmień stan\n" +
                                             "4 - Wymień spalone żarówkę\n" +
                                             "z - Zakończ\n" +
                                             "Wybierz opcję: ";

        public static void ShowMenu()
        {
            ConsoleColor currentForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("\n--->Sterowanie światłem<---");

            Console.ForegroundColor = currentForegroundColor;

            Console.Write(textLightMenu);
        }
    }
}
