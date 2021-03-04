using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class BulbBurnedOutState : BulbState
    {
        public override void TurnOffBulb(Bulb bulb, int number)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray; 

            Console.WriteLine($"Żarówka {number} jest już wyłączona. Nic nie robię.");

            Console.ForegroundColor = Bulb.currentForegroundColor;
        }

        public override void TurnOnBulb(Bulb bulb, int number)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"Nie mogę zapalić przypalonej żarówki {number}. Nic nie robię.");

            Console.ForegroundColor = Bulb.currentForegroundColor;
        }

  
    }
}
