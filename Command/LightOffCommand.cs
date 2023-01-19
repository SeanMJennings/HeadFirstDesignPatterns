using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightOffCommand : Command
    {
        private Light light;
        public LightOffCommand(Light light) { this.light = light; }

        public void Execute() { light.Off(); }

        public void Undo() { light.On(); }
    }
}
