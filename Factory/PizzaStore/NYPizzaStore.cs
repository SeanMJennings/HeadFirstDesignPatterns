using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Factory.Ingredients.NY;
using Factory.Pizza;

namespace Factory.PizzaStore
{
    public class NYPizzaStore : PizzaStore
    {
        protected override void CreatePizza(Pizzas pizzaType)
        {
            switch(pizzaType)
            {
                case Pizzas.Clam:
                    this.Pizza = new ClamPizza(new NYIngredientFactory());
                    this.Pizza.Name = "NY Style Clam Pizza";
                    break;
                case Pizzas.Cheese:
                    this.Pizza = new CheesePizza(new NYIngredientFactory());
                    this.Pizza.Name = "NY Style Cheese Pizza";
                    break;
                case Pizzas.Pepperoni:
                    this.Pizza = new PepperoniPizza(new NYIngredientFactory());
                    this.Pizza.Name = "NY Style Pepperoni Pizza";
                    break;
                case Pizzas.Veggie:
                    this.Pizza = new VeggiePizza(new NYIngredientFactory());
                    this.Pizza.Name = "NY Style Veggie Pizza";
                    break;
                default:
                    throw new Exception();

            }
        }
    }
}
