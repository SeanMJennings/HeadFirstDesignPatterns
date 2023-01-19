using Factory.Ingredients;
using Factory.Ingredients.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizza
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            this.Dough = this.IngredientFactory.CreateDough();
            this.Cheese = this.IngredientFactory.CreateCheese();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Veggies = this.IngredientFactory.CreateVeggies();
        }
    }
}
