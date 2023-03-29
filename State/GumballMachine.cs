using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class GumballMachine
    {
        private NoQuarter noQuarter;
        private HasQuarter hasQuarter;
        private GumballSold gumballSold;
        private Winner winner;
        private SoldOut soldOut;
        private State state;
        private int GumballCount;

        public GumballMachine(int gumballCount)
        {
            this.noQuarter = new NoQuarter(this);
            this.hasQuarter = new HasQuarter(this);
            this.gumballSold = new GumballSold(this);
            this.winner = new Winner(this);
            this.soldOut = new SoldOut(this);

            this.state = this.noQuarter;
            GumballCount = gumballCount;
        }

        internal NoQuarter NoQuarter { get { return this.noQuarter; } }
        internal HasQuarter HasQuarter { get { return this.hasQuarter; } }
        internal GumballSold GumballSold { get { return this.gumballSold; } }
        internal Winner Winner { get { return this.winner; } }
        internal SoldOut SoldOut { get {  return this.soldOut; } }

        internal State GetState()
        {
            return this.state;
        }

        internal void SetState(State state)
        {
            this.state = state;
        }

        internal int GetGumballCount()
        {
            return this.GumballCount;
        }

        internal void ReleaseGumball(int gumballs = 1)
        {
            this.GumballCount -= gumballs;
        }

        public void InsertQuarter()
        {
            this.state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            this.state.EjectQuarter();
        }

        public void TurnCrank()
        {
            this.state.TurnCrank();
        }

        public void Dispense()
        {
            this.state.Dispense();
        }
    }
}
