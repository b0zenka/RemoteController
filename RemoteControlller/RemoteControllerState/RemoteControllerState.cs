using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    abstract class RemoteControllerState
    {
        public abstract void Show();
        public abstract void GetCommand(ConsoleKey key);
    }
}
