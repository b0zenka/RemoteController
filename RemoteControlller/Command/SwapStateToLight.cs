using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class SwapStateToLight : Command
    {
        public void Execute()
        {
            Program.remoteControllerState = Program.LIGHT_STATE;
        }
    }
}
