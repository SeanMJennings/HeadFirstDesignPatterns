using Factory.Ingredients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Ingredients.Chicago
{
    public class ChicagoIngredientFactory : IngredientFactory
    {
        public ChicagoIngredientFactory() { }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Pepperoni CreatePepperoni()
        {
            return new ChunkyPepperoni();
        }

        public Veggie[] CreateVeggies()
        {
            return new Veggie[] { new Pepper(), new Onion() };
        }
    }
}
