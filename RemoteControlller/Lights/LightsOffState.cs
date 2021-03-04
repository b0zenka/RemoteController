using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class LightsOffState : LightsState
    {
        public override void TurnOn()
        {
            int i = 1;
            foreach (var bulb in Light.bulbs)
            {
                bulb.TurnOn(i++);
            }

            Console.WriteLine("Światła zostały włączone.");
            Light.currentLightState = Light.LIGHTS_ON_STATE;
        }

        public override void TurnOff()
        {
            Console.WriteLine("Światła są już wyłączone. Nic nie robię.");            
        }


    }
}
