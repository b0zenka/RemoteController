using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    abstract class LightsState
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
