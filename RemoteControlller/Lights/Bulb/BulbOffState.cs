using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class BulbOffState : BulbState
    {
        

        public override void TurnOnBulb(Bulb bulb, int number)
        {
            bulb.currentBulbState = Program.random.TrueFalse() ? bulb.BULB_ON_STATE : bulb.BULB_BURNED_OUT_STATE;
            if (bulb.currentBulbState.Equals(bulb.BULB_ON_STATE))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"Żarówka {number} została włączona.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine($"Żarówka {number} właśnie się przypaliła.");
            }

            Console.ForegroundColor = Bulb.currentForegroundColor;
            
        }

        public override void TurnOffBulb(Bulb bulb, int number)
        {
            Console.WriteLine($"Żarówka {number} jest już wyłączona. Nic nie robię.");
        }

    }
}
