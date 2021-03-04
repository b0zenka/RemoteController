using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandOpenWindow : Command
    {
        public void Execute()
        {
            WindowRemoteControllerState.windows.Open();
        }
    }
}
