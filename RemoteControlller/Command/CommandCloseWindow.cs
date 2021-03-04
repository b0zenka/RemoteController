﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandCloseWindow : Command
    {
        public void Execute()
        {
            WindowRemoteControllerState.windows.Close();
        }
    }
}
