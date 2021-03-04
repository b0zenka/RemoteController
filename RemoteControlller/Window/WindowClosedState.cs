using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class WindowClosedState : WindowState
    {
        public override void OpenWindow()
        {
            Console.WriteLine("Okna zostały otwarte.");
            Window.currentWindowState = Window.WINDOW_OPEN_STATE;
        }

        public override void CloseWindow()
        {
            Console.WriteLine("Okna zamknięte. Nic nie robię.");
        }
    }
}
