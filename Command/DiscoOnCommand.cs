using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DiscoOnCommand : Command
    {
        private Command[] commands;

        public DiscoOnCommand() 
        {
            this.commands = new Command[2];
            this.commands[0] = new GarageDoorOpenCommand(new GarageDoor());
            this.commands[1] = new LightOnConmnand(new Light());
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
