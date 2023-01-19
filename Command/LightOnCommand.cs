using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightOnConmnand : Command
    {
        private Light light;
        public LightOnConmnand(Light light) { this.light = light; }

        public void Execute() { light.On(); }

        public void Undo() { light.Off(); }
    }
}
