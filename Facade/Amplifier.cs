using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Amplifier
    {
        public void TurnOnAmplifier()
        {
            Console.WriteLine("Turning on amplifier");
        }

        public void TurnOffAmplifier()
        {
            Console.WriteLine("Turning off amplifier");
        }
    }
}
