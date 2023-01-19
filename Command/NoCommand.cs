using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class NoCommand : Command
    {
        public NoCommand() { }

        public void Execute()
        {
            Console.WriteLine("No command");
        }

        public void Undo()
        {
            Console.WriteLine("No command");
        }
    }
}
