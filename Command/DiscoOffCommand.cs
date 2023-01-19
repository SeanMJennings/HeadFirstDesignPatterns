using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DiscoOffCommand : Command
    {
        private Command[] commands;

        public DiscoOffCommand()
        {
            this.commands = new Command[2];
            this.commands[0] = new GarageDoorCloseCommand(new GarageDoor());
            this.commands[1] = new LightOffCommand(new Light());
        }

        public void Execute()
        {
            foreach (var command in this.commands) { command.Execute(); }
        }

        public void Undo()
        {
            foreach (var command in this.commands) { command.Undo(); }
        }
    }
}
