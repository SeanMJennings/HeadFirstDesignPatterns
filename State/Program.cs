using State;

var gumballMachine = new GumballMachine(5);
gumballMachine.Dispense();
gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();
gumballMachine.TurnCrank();

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.Dispense();

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.Dispense();

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.Dispense();

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.Dispense();

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.Dispense();

gumballMachine.InsertQuarter();