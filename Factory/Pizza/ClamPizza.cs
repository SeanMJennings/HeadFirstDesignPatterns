using Factory.Ingredients;
using Factory.Ingredients.Chicago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizza
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IngredientFactory ingredientFactory) : base(ingredientFactory) { }

        public override void Prepare()
        {
            this.Dough = this.IngredientFactory.CreateDough();
            this.Clams = this.IngredientFactory.CreateClams();
            this.Sauce = this.IngredientFactory.CreateSauce();
            this.Veggies = this.IngredientFactory.CreateVeggies();
        }
    }
}
