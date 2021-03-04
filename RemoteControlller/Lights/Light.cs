using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class Light
    {
        public const int BULBSIZE = 10;
        public static readonly LightsState LIGHTS_OFF_STATE = new LightsOffState();
        public static readonly LightsState LIGHTS_ON_STATE = new LightsOnState();
        public static LightsState currentLightState = LIGHTS_OFF_STATE;
        public static Bulb[] bulbs = new Bulb [BULBSIZE];

        public Light()
        {
            for (int i = 0; i < bulbs.Length; i++)
                bulbs[i] = new Bulb();
        }

        public void LightTurnOn()
        {
            currentLightState.TurnOn();            
        }

        public void LightTurnOff()
        {
            currentLightState.TurnOff();
        }

        public void ReplaceBurnedOutBulb()
        {
            Console.WriteLine("Przed wymianą żarówek wyłączyć światło:");
            currentLightState.TurnOff();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nWymiana żarówek:");
            for (int i = 0; i < bulbs.Length; i++)
            {
                if (bulbs[i].isBurnedOut())
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Żarówka {i + 1} wymieniona na nową.");
                    bulbs[i] = new Bulb();
                    Console.ForegroundColor = Bulb.currentForegroundColor;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Żarówka {i + 1} jest okay. Nic nie robię.");
                    Console.ForegroundColor = Bulb.currentForegroundColor;
                }
            }
            Console.WriteLine("Żarówki zostały wymienione.");

        }
    }
}
