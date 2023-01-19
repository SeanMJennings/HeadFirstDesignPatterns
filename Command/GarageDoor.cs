using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class GarageDoor
    {
        public GarageDoor() { }

        public void Open() { Console.WriteLine("Opening garage door"); }

        public void Close() { Console.WriteLine("Closing garage door"); }
    }
}
