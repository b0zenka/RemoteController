using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    abstract class BulbState
    {
        public abstract void TurnOnBulb(Bulb bulb, int number);
        public abstract void TurnOffBulb(Bulb bulb, int number);
    }
}
