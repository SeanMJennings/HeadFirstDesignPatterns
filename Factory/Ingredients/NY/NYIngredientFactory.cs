using Factory.Ingredients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.NY
{
    public class NYIngredientFactory : IngredientFactory
    {
        public NYIngredientFactory() { }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new ThinPepperoni();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[] { new Spinach(), new Tomato() };
        }
    }
}

