using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class LightRemoteControllerState : RemoteControllerState
    {     
        public Dictionary<ConsoleKey, Command> command;
        public static Light light;

        public LightRemoteControllerState()
        {
            light = new Light();
            command = new Dictionary<ConsoleKey, Command>();
            command.Add(ConsoleKey.D0, new CommandCloseAll());
            command.Add(ConsoleKey.NumPad0, new CommandCloseAll());
            command.Add(ConsoleKey.D1, new CommandTurnOnLight());
            command.Add(ConsoleKey.NumPad1, new CommandTurnOnLight());
            command.Add(ConsoleKey.D2, new CommandTurnOffLight());
            command.Add(ConsoleKey.NumPad2, new CommandTurnOffLight());
            command.Add(ConsoleKey.D3, new SwapSateToWindow());
            command.Add(ConsoleKey.NumPad3, new SwapSateToWindow());
            command.Add(ConsoleKey.D4, new CommandReplaceTheBulb()); //wymien żarowki
            command.Add(ConsoleKey.NumPad4, new CommandReplaceTheBulb());
            command.Add(ConsoleKey.Z, new CommandExit());
        }

        public override void Show()
        {
            MenuLight.ShowMenu();   
        }

        public override void GetCommand(ConsoleKey key)
        {
            Console.Clear();

            // The indexer throws an exception if the requested key is
            // not in the dictionary
            try
            {
                command[key].Execute();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Błędny wybór. Spróbuj ponownie.");
            }
        }
    }
}
