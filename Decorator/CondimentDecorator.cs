namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage { get; private set; }

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
