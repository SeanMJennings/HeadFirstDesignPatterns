using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class NoQuarter : State
    {
        private GumballMachine machine;

        public NoQuarter(GumballMachine gumball) 
        {
            this.machine = gumball;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter inserted");
            this.machine.SetState(this.machine.HasQuarter);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("No quarter inserted");
        }

        public void TurnCrank()
        {
            Console.WriteLine("No quarter inserted");
        }

        public void Dispense()
        {
            Console.WriteLine("Gumball not sold");
        }
    }
}
