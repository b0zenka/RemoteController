using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class CommandExit : Command
    {
        public void Execute()
        {
            Environment.Exit(1);
        }
    }
}
