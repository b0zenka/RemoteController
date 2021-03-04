using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlller
{
    class WindowRemoteControllerState : RemoteControllerState
    {
        public Dictionary<ConsoleKey, Command> command;
        public static Window windows;

        public WindowRemoteControllerState()
        {
            windows = new Window();
            command = new Dictionary<ConsoleKey, Command>();
            command.Add(ConsoleKey.D0, new CommandCloseAll());
            command.Add(ConsoleKey.NumPad0, new CommandCloseAll());
            command.Add(ConsoleKey.D1, new CommandOpenWindow());
            command.Add(ConsoleKey.NumPad1, new CommandOpenWindow());
            command.Add(ConsoleKey.D2, new CommandCloseWindow());
            command.Add(ConsoleKey.NumPad2, new CommandCloseWindow());
            command.Add(ConsoleKey.D3, new SwapStateToLight());
            command.Add(ConsoleKey.NumPad3, new SwapStateToLight());
            command.Add(ConsoleKey.Z, new CommandExit());
        }

        public override void Show()
        {
            MenuWindow.ShowMenu();
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
