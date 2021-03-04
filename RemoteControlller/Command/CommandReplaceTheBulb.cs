using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandReplaceTheBulb : Command
    {
        public void Execute()
        {
            LightRemoteControllerState.light.ReplaceBurnedOutBulb();
        }
    }
}
