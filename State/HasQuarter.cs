using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class HasQuarter : State
    {
        private GumballMachine machine;
        private Random rand;

        public HasQuarter(GumballMachine gumball)
        {
            this.machine = gumball;
            this.rand = new Random();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Quarter already inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter ejected");
            this.machine.SetState(this.machine.NoQuarter);
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning crank");
            if (this.rand.Next(5) == 3)
            {
                Console.WriteLine("We have a winner!");
                this.machine.SetState(this.machine.Winner);
                return;
            }
            this.machine.SetState(this.machine.GumballSold);
        }

        public void Dispense()
        {
            Console.WriteLine("Gumball not sold");
        }
    }
}
