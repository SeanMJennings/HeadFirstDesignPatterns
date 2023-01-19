using Factory.Ingredients;
using Factory.Ingredients.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizza
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            this.Dough = this.IngredientFactory.CreateDough();
            this.Pepperoni = this.IngredientFactory.CreatePepperoni();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Veggies = this.IngredientFactory.CreateVeggies();
        }
    }
}
