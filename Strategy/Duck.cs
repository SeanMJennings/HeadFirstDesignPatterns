namespace Strategy
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;

        public Duck()
        {
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
        }

        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            this.quackBehaviour = quackBehaviour;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float");
        }
    }
}
