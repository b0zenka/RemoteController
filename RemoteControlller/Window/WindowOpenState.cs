using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class WindowOpenState : WindowState
    {
        public override void OpenWindow()
        {
            Console.WriteLine("Okna otwarte. Nic nie robię.");
        }

        public override void CloseWindow()
        {
            Console.WriteLine("Okna zostały zamknięte.");
            Window.currentWindowState = Window.WINDOW_CLOSE_STATE;
        }
    }
}
