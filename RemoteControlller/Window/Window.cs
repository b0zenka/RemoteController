using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class Window
    {
        public static readonly WindowClosedState WINDOW_CLOSE_STATE = new WindowClosedState();
        public static readonly WindowOpenState WINDOW_OPEN_STATE = new WindowOpenState();
        public static WindowState currentWindowState = WINDOW_CLOSE_STATE;

        public void Open()
        {
            currentWindowState.OpenWindow();

        }

        public void Close()
        {
            currentWindowState.CloseWindow();
        }

    }
}
