using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class SoldOut : State
    {
        private GumballMachine machine;

        public SoldOut(GumballMachine gumball)
        {
            this.machine = gumball;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sold out of gumballs");
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


