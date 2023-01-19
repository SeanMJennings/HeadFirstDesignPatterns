using Factory.Ingredients;
using Factory.Ingredients.Veggies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizza
{
    public abstract class Pizza
    {
        public IngredientFactory IngredientFactory { get; protected set; }
        public Dough Dough { get; protected set; }
        public Cheese Cheese { get; protected set; }
        public Pepperoni Pepperoni { get; protected set; }
        public Sauce Sauce { get; protected set; }
        public Clams Clams { get; protected set; }
        public Veggie[] Veggies { get; protected set; }
        public string Name { get; set; }

        public Pizza(IngredientFactory ingredientFactory) { this.IngredientFactory = ingredientFactory; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting");
        }

        public void Box()
        {
            Console.WriteLine("Boxing");
        }
    }
}
