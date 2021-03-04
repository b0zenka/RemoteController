using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    abstract class WindowState
    {
        public abstract void OpenWindow();
        public abstract void CloseWindow();
    }
}
