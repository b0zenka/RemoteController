using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class Bulb                  //żarówka
    {
        public readonly BulbState BULB_ON_STATE = new BulbOnState();
        public readonly BulbState BULB_OFF_STATE = new BulbOffState();
        public readonly BulbState BULB_BURNED_OUT_STATE = new BulbBurnedOutState();
        public BulbState currentBulbState;
        public static ConsoleColor currentForegroundColor = Console.ForegroundColor;

        public Bulb()
        {
            currentBulbState = BULB_OFF_STATE;
        }

        public void TurnOn(int number)
        {
            currentBulbState.TurnOnBulb(this, number);
        }

        public void TurnOff(int number)
        {
            currentBulbState.TurnOffBulb(this, number);
        }

        public bool isBurnedOut()
        {
            return currentBulbState.Equals(BULB_BURNED_OUT_STATE);
        }

    }
}
