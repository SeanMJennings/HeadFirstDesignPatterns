using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface State
    {
        public void InsertQuarter();

        public void EjectQuarter();

        public void TurnCrank();

        public void Dispense();
    }
}
