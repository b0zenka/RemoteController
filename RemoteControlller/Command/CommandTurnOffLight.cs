using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandTurnOffLight : Command
    {
        public void Execute()
        {
            LightRemoteControllerState.light.LightTurnOff();
        }
    }
}
