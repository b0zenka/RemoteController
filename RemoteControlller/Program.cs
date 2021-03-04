using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class Program
    {
        public static readonly RemoteControllerState WINDOW_STATE = new WindowRemoteControllerState();
        public static readonly RemoteControllerState LIGHT_STATE = new LightRemoteControllerState();
        public static RemoteControllerState remoteControllerState = LIGHT_STATE;

        public static Random random = new Random();
       
        static void Main(string[] args)
        {
            Console.WriteLine("--->Rozpoczęcie pracy pilota<---");

            while (true)
            {
                remoteControllerState.Show();
                    try
                    {
                        remoteControllerState.GetCommand(Console.ReadKey().Key);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Błąd: {0}", e.Message);
                    }

              
            };
        }
    }
}
