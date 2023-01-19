using Factory.Ingredients;

namespace Factory.Pizza
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            this.Dough = this.IngredientFactory.CreateDough();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Veggies = this.IngredientFactory.CreateVeggies();
        }
    }
}
