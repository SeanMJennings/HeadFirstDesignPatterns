using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class GarageDoorOpenCommand : Command
    {
        private GarageDoor garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor) { this.garageDoor = garageDoor; }

        public void Execute() { garageDoor.Open(); }

        public void Undo() { garageDoor.Close(); }
    }
}
