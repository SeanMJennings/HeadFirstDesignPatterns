using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class GumballSold : State
    {
        private GumballMachine machine;

        public GumballSold(GumballMachine gumball)
        {
            this.machine = gumball;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter already inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Crank already turned");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank already turned");
        }

        public void Dispense()
        {
            Console.WriteLine("Dispensing gumball");

            if (machine.GetGumballCount() > 1)
            {
                this.machine.ReleaseGumball();
                this.machine.SetState(this.machine.NoQuarter);
                return;
            }
            this.machine.ReleaseGumball();
            this.machine.SetState(this.machine.SoldOut);
        }
    }
}

