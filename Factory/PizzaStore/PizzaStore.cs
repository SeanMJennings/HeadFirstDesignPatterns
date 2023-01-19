using Factory.Pizza;

namespace Factory.PizzaStore
{
    public abstract class PizzaStore
    {
        public Pizza.Pizza Pizza { get; protected set; }

        protected abstract void CreatePizza(Pizzas pizzaType);

        public Pizza.Pizza ServePizza(Pizzas pizzaType)
        {
            this.CreatePizza(pizzaType);
            this.Pizza.Prepare();
            this.Pizza.Bake();
            this.Pizza.Cut();
            this.Pizza.Box();
            return this.Pizza;
        }
    }
}
