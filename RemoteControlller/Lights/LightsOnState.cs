using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class LightsOnState : LightsState
    {
        public override void TurnOn()
        {
            Console.WriteLine("Światła są już włączone. Nic nie robię.");
        }

        public override void TurnOff()
        {
            int i = 1;
            foreach (var bulb in Light.bulbs)
            {
                bulb.TurnOff(i++);
            }

            Console.WriteLine("Światła zostały wyłączone.");
            Light.currentLightState = Light.LIGHTS_OFF_STATE;
        }
    }
}
