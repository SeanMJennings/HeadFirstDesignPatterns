using Strategy;

var mallardDuck = new MallardDuck();

mallardDuck.PerformQuack();
mallardDuck.PerformFly();
mallardDuck.SetFlyBehaviour(new FlyWithRockets());
mallardDuck.PerformFly();