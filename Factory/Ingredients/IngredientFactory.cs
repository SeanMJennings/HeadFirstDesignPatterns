using Factory.Ingredients.Veggies;

namespace Factory.Ingredients
{
    public interface IngredientFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Clams CreateClams();

        public Pepperoni CreatePepperoni();

        public Cheese CreateCheese();

        public Veggie[] CreateVeggies();
    }
}
