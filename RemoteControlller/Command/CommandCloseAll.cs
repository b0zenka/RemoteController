using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandCloseAll : Command
    {
        public void Execute()
        {
            WindowRemoteControllerState.windows.Close();
            LightRemoteControllerState.light.LightTurnOff();
        }
    }
}
