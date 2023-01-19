using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class GarageDoorCloseCommand : Command
    {
        private GarageDoor garageDoor;
        public GarageDoorCloseCommand(GarageDoor garageDoor) { this.garageDoor = garageDoor; }

        public void Execute() { garageDoor.Close(); }

        public void Undo() { garageDoor.Open(); }
    }
}
