using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class BulbOnState : BulbState
    {
        public override void TurnOnBulb(Bulb bulb, int number)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"Żarówka {number} jest już włączona. Nic nie robię.");

            Console.ForegroundColor = Bulb.currentForegroundColor;
        }

        public override void TurnOffBulb(Bulb bulb, int number)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"Żarówka {number} została zgaszona.");

            Console.ForegroundColor = Bulb.currentForegroundColor;

            bulb.currentBulbState = bulb.BULB_OFF_STATE;
        }

    }
}
